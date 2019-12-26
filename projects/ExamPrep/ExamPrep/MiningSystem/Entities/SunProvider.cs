using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public class SunProvider : Provider
    {
        public SunProvider(double energyOutput, string id) : base(energyOutput, id)
        {
            base.EnergyOutput += base.EnergyOutput * 25 / 100;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sun Provider - {base.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
