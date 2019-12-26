using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public class EnduranceDriver : Driver
    {
        private const double FuelConsumption = 1.5;
        public EnduranceDriver(Car car, string name) : base(FuelConsumption, car, name)
        {
        }
    }
}
