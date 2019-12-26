using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public class Driller : Miner
    {
        private const int CoalMiltiplier = 3;
        private const int EnergyMiltiplier = 2;

        public Driller(string id, double coalOutput, double energyRequirement)
            : base(id, coalOutput, energyRequirement)
        {
            base.CoalOutput = this.CoalOutput * CoalMiltiplier;
            base.EnergyRequirement = this.EnergyRequirement * EnergyMiltiplier;
        }
    }
}
