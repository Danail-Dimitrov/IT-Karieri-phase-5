using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Bus : Vehicle
    {
        private double consuptionWithOutPeople;
        public Bus(double gas, double consumptionPerKm, double capacity) : base(gas, consumptionPerKm, capacity)
        {
            consuptionWithOutPeople = consumptionPerKm;
        }

        public string DriveEmpty(double km)
        {
            if(base.ConsumptionPerKm != consuptionWithOutPeople)
            {
                base.ConsumptionPerKm = consuptionWithOutPeople;
            }

            return base.Drive(km);
        }

        public override string Drive(double km)
        {
            if(base.ConsumptionPerKm == consuptionWithOutPeople)
            {
                base.ConsumptionPerKm = consuptionWithOutPeople + 1.4;
            }

            return base.Drive(km);
        }
    }
}
