using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle
    {
        public Car(double gas, double consumptionPerKm, double capacity) : base(gas, 0.9 + consumptionPerKm, capacity)
        {
        }
    }
}
