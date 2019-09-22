using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    abstract class Vehicle
    {
        private double gas;
        private double consumptionPerKm;
        private double capacity;

        protected Vehicle(double gas, double consumptionPerKm, double capacity)
        {
            Gas = gas;
            ConsumptionPerKm = consumptionPerKm;
            Capacity = capacity;
        }

        public double Gas
        {
            get => gas;
            set => gas = value;
        }
        public double ConsumptionPerKm
        {
            get => consumptionPerKm;
            set => consumptionPerKm = value;
        }
        public double Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        protected virtual string Drive(double km)
        {
            double needed = km * this.ConsumptionPerKm;

            if(needed <= this.Gas)
            {
                double afterDriven = this.Gas - needed;

                if(afterDriven <= 0)
                {
                    return "Fuel must be a positive number";
                }

                this.Gas = afterDriven;

                return $"{this.GetType().Name} travelled {km} km";
            }

            return $"{this.GetType().Name} needs Refueling";
        }
        protected virtual string Refuel(double liters)
        {
            if(liters <= 0)
            {
                return "Fuel must be a positive number";
            }

            double aferAdded = this.Gas + liters;

            if(aferAdded > capacity)
            {
                return "Cannot fit fuel in tank";
            }

            this.Gas = aferAdded;

            return "";
        }
    }
}
