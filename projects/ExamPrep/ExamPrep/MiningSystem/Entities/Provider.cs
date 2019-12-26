using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities
{
    public abstract class Provider
    {
        private string id;
        private double energyOutput;

        protected Provider(double energyOutput, string id)
        {
            this.EnergyOutput = energyOutput;
            this.Id = id;
        }

        public double EnergyOutput
        {
            get
            {
                return this.energyOutput;
            }
            protected set
            {
                if(value > 10000)
                {
                    throw new InvalidOperationException("Provider is not registered, because of it's EnergyOutput");
                }
                this.energyOutput = value;
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
            return $"Energy Output: {this.energyOutput}";
        }
    }
}
