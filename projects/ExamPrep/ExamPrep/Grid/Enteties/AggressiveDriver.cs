using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public class AggressiveDriver : Driver
    {
        private const double FuelConsumption = 2.7;
        private const double SpeedMultyplier = 1.3;
        public AggressiveDriver(Car car, string name) : base(FuelConsumption, car, name)
        {
            base.Speed *= SpeedMultyplier;
        }
    }
}
