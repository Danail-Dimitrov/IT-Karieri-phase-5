using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double FuelConsumptionPerKmConst = 1.5;

        public EnduranceDriver(string name, Car car) 
            : base(name, car, FuelConsumptionPerKmConst)
        {
        }
    }
}
