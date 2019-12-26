using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Drivers
{
    public class AggressiveDriver : Driver
    {
        private const double FuelConsumptionPerKmConst = 2.7;
        private const double SpeedMultiplier = 1.3;

        public AggressiveDriver(string name, Car car) 
            : base(name, car, FuelConsumptionPerKmConst)
        {
        }

        public override double Speed => base.Speed * SpeedMultiplier;
    }
}
