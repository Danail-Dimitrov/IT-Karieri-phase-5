using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Drivers
{
    public abstract class Driver
    {
        private const double InitialTotalTime = 0;

        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;

        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.TotalTime = InitialTotalTime;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        public Car Car
        {
            get { return car; }
            private set { car = value; }
        }

        public double FuelConsumptionPerKm
        {
            get { return fuelConsumptionPerKm; }
            private set { fuelConsumptionPerKm = value; }
        }

        public virtual double Speed
        {
            get
            {
                return speed = (car.Hp + car.Tyre.Degradation) / car.FuelAmount;
            }
        }
    }
}
