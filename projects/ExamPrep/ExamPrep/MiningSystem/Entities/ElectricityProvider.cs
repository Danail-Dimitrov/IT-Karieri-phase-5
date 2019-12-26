using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public class ElectricityProvider : Provider
    {
        public ElectricityProvider(double energyOutput, string id) : base(energyOutput, id)
        {
            base.EnergyOutput += base.EnergyOutput * 50 / 100;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Electricity Provider - {base.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
