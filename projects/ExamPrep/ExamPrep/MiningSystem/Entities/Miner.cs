using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public abstract class Miner
    {
        private string id;
        private double coalOutput;
        private double energyRequirement;

        protected Miner(double energyRequirement, double coalOutput, string id)
        {
            this.EnergyRequirement = energyRequirement;
            this.CoalOutput = coalOutput;
            this.Id = id;
        }

        public double EnergyRequirement
        {
            get
            {
                return this.energyRequirement;
            }
            protected set
            {
                if(value < 0 || value > 20000)
                {
                    throw new InvalidOperationException("Miner is not registered, because of it's EnergyRequirement");
                }
                this.energyRequirement = value;
            }
        }
        public double CoalOutput
        {
            get
            {
                return this.coalOutput;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new InvalidOperationException("Miner is not registered, because of it's CoalOutput");
                }
                this.coalOutput = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Coal Output: {this.CoalOutput}");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim();
        }
    }
}
