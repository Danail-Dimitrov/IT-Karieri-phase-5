using Grid.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grid.Core
{
    public class RaceTower
    {
        private Dictionary<string, Driver> drivers;
        private Dictionary<Driver, string> crashedDrivers;
        private int laps;
        private double lenght;
        private int currentLap;
        private bool hasWinner;

        public RaceTower()
        {
            drivers = new Dictionary<string, Driver>();
            crashedDrivers = new Dictionary<Driver, string>();
            CurrentLap = 0;
            HasWinner = false;
        }

        public IReadOnlyDictionary<string, Driver> Drivers
        {
            get
            {
                return drivers;
            }
        }
        public IReadOnlyDictionary<Driver, string> CrashedDrivers
        {
            get
            {
                return crashedDrivers;
            }
        }
        public int Laps
        {
            get
            {
                return laps;
            }
            private set
            {
                laps = value;
            }
        }
        public int CurrentLap
        {
            get
            {
                return currentLap;
            }
            private set
            {
                currentLap = value;
            }
        }
        public double Lenght
        {
            get
            {
                return lenght;
            }
            private set
            {
                lenght = value;
            }
        }
        public bool HasWinner
        {
            get
            {
                return hasWinner;
            }
            private set
            {
                hasWinner = value;
            }
        }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            Laps = lapsNumber;
            Lenght = trackLength;
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
            Car car = null;
            Driver driver = null;

            if(tyreType == "Ultrasoft")
            {
                double grip = double.Parse(commandArgs[6]);
                tyre = new UltrasoftTyre(tyreHardness, grip);
            }
            else
            {
                tyre = new HardTyre(tyreHardness);
            }

            car = new Car(tyre, fuelAmount, hp);

            if(type == "Aggressive")
            {
                driver = new AggressiveDriver(car, name);
            }
            else
            {
                driver = new EnduranceDriver(car, name);
            }

            drivers.Add(name, driver);
        }
        public void DriverBoxes(List<string> commandArgs)
        {
            string reason = commandArgs[0];
            string name = commandArgs[1];

            if(reason == "ChangeTyres")
            {
                string tyreType = commandArgs[2];
                double hardness = double.Parse(commandArgs[3]);
                Tyre tyre = null;

                if(tyreType == "Ultrasoft")
                {
                    double grip = double.Parse(commandArgs[4]);
                    tyre = new UltrasoftTyre(hardness, grip);
                }
                else
                {
                    tyre = new HardTyre(hardness);
                }

                drivers[name].Car.Tyre = tyre;
            }
            else
            {
                double fuelAmount = double.Parse(commandArgs[2]);
                drivers[name].Car.FuelAmount = fuelAmount;
            }

            drivers[name].TotalTime += 20;
        }
        public string CompleteLaps(List<string> commandArgs)
        {
            int lapsToMake = int.Parse(commandArgs[0]);

            if(CurrentLap + lapsToMake > Laps)
            {
                throw new InvalidOperationException($"There is no time! On lap {CurrentLap}.");
            }

            Dictionary<Driver, string> toRemove = new Dictionary<Driver, string>();


            foreach(var pair in drivers)
            {
                Driver driver = pair.Value;

                try
                {
                    for(int i = 1; i <= lapsToMake; i++)
                    {
                        driver.TotalTime += 60 / (Lenght / driver.Speed);
                        driver.Car.FuelAmount -= Lenght * driver.FuelConsumptionPerKm;
                        driver.Car.Tyre.Degrade();
                    }
                }
                catch(ArgumentException ex)
                {
                    if(ex.Message == "Blow Tyre")
                    {
                        toRemove.Add(driver, "Blow tyre");
                    }
                    else if(ex.Message == "Out of fuel")
                    {
                        toRemove.Add(driver, "Out of fuel");
                    }
                }
            }

            foreach(var pair in toRemove)
            {
                crashedDrivers.Add(pair.Key, pair.Value);
                drivers.Remove(pair.Key.Name);
            }


            CurrentLap += lapsToMake;

            if(CurrentLap == Laps)
            {
                List<Driver> driversList = GetOrderedList();
                Driver winner = driversList[0];

                HasWinner = true;

                return $"{winner.Name} wins the race for {winner.TotalTime} seconds.";
            }

            return "";
        }
        public string GetLeaderboard()
        {
            StringBuilder sb = new StringBuilder();
            List<Driver> driversList = GetOrderedList();
            crashedDrivers.OrderBy(x => x.Key.TotalTime);

            int positionCounter = 1;

            sb.AppendLine($"Lap {CurrentLap}/{Laps}");
            for(int i = 0; i < driversList.Count; i++)
            {
                sb.AppendLine($"{positionCounter} {driversList[i].Name} {driversList[i].TotalTime}");
                positionCounter++;
            }

            foreach(var pair in crashedDrivers)
            {
                sb.AppendLine($"{positionCounter} {pair.Key.Name} {pair.Value}");
                positionCounter++;
            }

            return sb.ToString().Trim();
        }

        private List<Driver> GetOrderedList()
        {
            return drivers.Select(x => x.Value).OrderBy(x => x.TotalTime).ToList();
        }
    }
}
