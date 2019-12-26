using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public class SunProvider : Provider
    {
        private const double EnergyOutputMultiplier = 1.25;

        public SunProvider(string id, double energyOutput)
            :base(id, energyOutput)
        {
            this.EnergyOutput = this.EnergyOutput * EnergyOutputMultiplier;
        }

        public override string Type => "Sun";
    }
}
