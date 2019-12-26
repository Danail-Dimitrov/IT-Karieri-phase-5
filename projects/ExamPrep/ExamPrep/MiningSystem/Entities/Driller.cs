using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public class Driller : Miner
    {
        public Driller(double energyRequirement, double coalOutput, string id) : base(energyRequirement, coalOutput, id)
        {
            base.CoalOutput *= 3;
            base.EnergyRequirement *= 2;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Driller Miner - {base.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
