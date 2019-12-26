using ExamPrepDemo.Entities;
using ExamPrepDemo.Entities.Drivers;
using ExamPrepDemo.Entities.Tyres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepDemo.Core
{
    public class RaceTower
    {
        private const int InitialLap = 0;
        private const int BoxAdditionalTime = 20;

        private int trackLength;
        private int totalLaps;
        private int currentLap;
        private List<Driver> drivers;
        private Dictionary<Driver, string> faildDrivers;

        public RaceTower()
        {
            this.currentLap = InitialLap;
            this.drivers = new List<Driver>();
            this.faildDrivers = new Dictionary<Driver, string>();
            this.HasWinner = false;
        }

        public bool HasWinner { get; set; }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.trackLength = trackLength;
            this.totalLaps = lapsNumber;
        }
        public void RegisterDriver(List<string> commandArgs)
        {
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            double tyreHardness = double.Parse(commandArgs[5]);

            Tyre tyre = null;

            if (tyreType == "Ultrasoft")
            {
                double tyreGrip = double.Parse(commandArgs[6]);
                tyre = new UltrasoftTyre(tyreHardness, tyreGrip);
            }
            else if (tyreType == "Hard")
            {
                tyre = new HardTyre(tyreHardness);
            }

            Car car = new Car(hp, fuelAmount, tyre);

            Driver driver = null;

            if (type == "Aggressive")
            {
                driver = new AggressiveDriver(name, car);
            }
            else if (type == "Endurance")
            {
                driver = new EnduranceDriver(name, car);
            }

            if (tyre == null || driver == null)
            {
                return;
            }

            this.drivers.Add(driver);
        }
        public void DriverBoxes(List<string> commandArgs)
        {
            string reason = commandArgs[0];
            string driverName = commandArgs[1];

            Driver driver = this.drivers
                .FirstOrDefault(x => x.Name == driverName);

            driver.TotalTime += BoxAdditionalTime;

            if (reason == "ChangeTyres")
            {
                string tyreType = commandArgs[2];
                double tyreHardness = double.Parse(commandArgs[3]);

                Tyre tyre = new HardTyre(tyreHardness);

                if (tyreType == "Ultrasoft")
                {
                    double grip = double.Parse(commandArgs[4]);
                    tyre = new UltrasoftTyre(tyreHardness, grip);
                }

                driver.Car.Tyre = tyre;
            }
            else if (reason == "Refuel")
            {
                double fuel = double.Parse(commandArgs[2]);
                driver.Car.FuelAmount += fuel;
            }

        }
        public string CompleteLaps(List<string> commandArgs)
        {
            int numberOfLaps = int.Parse(commandArgs[0]);

            if (this.currentLap + numberOfLaps > totalLaps)
            {
                throw new InvalidOperationException($"There is no time! On lap {currentLap}.");
            }

            for (int i = 0; i < drivers.Count; i++)
            {
                Driver currentDriver = drivers[i];

                try
                {
                    for (int j = 0; j < numberOfLaps; j++)
                    {
                        currentDriver.TotalTime += 60 / (trackLength / currentDriver.Speed);

                        currentDriver.Car.FuelAmount -= trackLength * currentDriver.FuelConsumptionPerKm;

                        currentDriver.Car.Tyre.DegradateTyre();
                    }
                }
                catch (ArgumentException ex)
                {
                    if (ex.Message == "Blow Tyre")
                    {
                        this.faildDrivers.Add(currentDriver, "Blow Tyre");
                    }
                    else if (ex.Message == "Out of fuel")
                    {
                        this.faildDrivers.Add(currentDriver, "Out of fuel");
                    }

                    this.drivers.Remove(currentDriver);
                    i--;
                }
            }

            this.currentLap += numberOfLaps;

            if (this.currentLap == this.totalLaps)
            {
                Driver winner = this.drivers
                    .OrderBy(x => x.TotalTime)
                    .FirstOrDefault();

                HasWinner = true;

                return $"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.";
            }

            return "";
        }

        public string GetLeaderboard()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Lap {currentLap}/{totalLaps}");

            List<Driver> orderedDrivers = this.drivers
                .OrderBy(x => x.TotalTime)
                .ToList();

            int position = 1;

            for (int i = 0; i < orderedDrivers.Count; i++)
            {
                Driver currentDriver = orderedDrivers[i];

                stringBuilder.AppendLine($"{position++} {currentDriver.Name} {currentDriver.TotalTime:F3}");
            }

            foreach (var currentDriver in faildDrivers)
            {
                stringBuilder.AppendLine($"{position++} {currentDriver.Key.Name} {currentDriver.Value}");
            }

            return stringBuilder.ToString().Trim();
        }

    }
}
