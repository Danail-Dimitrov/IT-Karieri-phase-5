using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public abstract class Provider
    {
        private string id;
        private double energyOutput;

        protected Provider(string id, double energyOutput)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public abstract string Type { get; }

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        public double EnergyOutput
        {
            get { return energyOutput; }
            protected set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException($"{nameof(this.EnergyOutput)}");
                }

                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            //“{type} Provider - { id}
            //Energy Output: { energyOutput}”

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Type} Provider - {this.Id}");
            stringBuilder.AppendLine($"Energy Output: {this.EnergyOutput}");

            return stringBuilder.ToString().Trim();
        }
    }
}
