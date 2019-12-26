using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public class Hewer : Miner
    {
        private int enduranceFactor;

        public Hewer(double energyRequirement, double coalOutput, string id, int enduranceFactor) : base(energyRequirement, coalOutput, id)
        {
            this.EnduranceFactor = enduranceFactor;
            base.EnergyRequirement /= this.EnduranceFactor;
        }

        public int EnduranceFactor
        {
            get
            {
                return this.enduranceFactor;
            }
            private set
            {
                this.enduranceFactor = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hewer Miner - {base.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
