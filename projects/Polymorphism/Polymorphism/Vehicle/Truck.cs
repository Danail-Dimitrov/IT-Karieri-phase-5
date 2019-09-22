namespace Vehicle
{
    class Truck : Vehicle
    {
        public Truck(double gas, double consumptionPerKm, double capacity) : base(gas, 1.6  + consumptionPerKm, capacity)
        {
        }

        public override string Refuel(double liters)
        {
            liters *= 0.95;

            string toReurn = base.Refuel(liters);

            return toReurn;
        }
    }
}
