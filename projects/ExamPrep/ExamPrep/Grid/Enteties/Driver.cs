using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public abstract class Driver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;

        protected Driver(double fuelConsumptionPerKm, Car car, string name)
        {
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            Car = car;
            Name = name;
            TotalTime = 0;
        }

        public double Speed
        {
            get
            {
                return (car.Hp + car.Tyre.Degradation) / car.FuelAmount;
            }
            protected set
            {
                speed = value;
            }
        }
        public double FuelConsumptionPerKm
        {
            get
            {
                return fuelConsumptionPerKm;
            }
            private set
            {
                fuelConsumptionPerKm = value;
            }
        }
        public Car Car
        {
            get
            {
                return car;
            }
            private set
            {
                car = value;
            }
        }
        public double TotalTime
        {
            get
            {
                return totalTime;
            }
            set
            {
                totalTime = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
    }
}
