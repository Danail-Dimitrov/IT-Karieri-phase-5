using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public class ElectricityProvider : Provider
    {
        private const double EnergyOutputMultiplier = 1.5;

        public ElectricityProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
            this.EnergyOutput = this.EnergyOutput * EnergyOutputMultiplier;
        }

        public override string Type => "Electricity";
    }
}
