using MiningSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class SystemManager
    {
        private List<Miner> miners;
        private List<Provider> providers;
        private double totalStoredEnergy;
        private double totalMinedCoal;

        public SystemManager()
        {
            this.miners = new List<Miner>();
            this.providers = new List<Provider>();
            this.TotalMinedCoal = 0;
            this.TotalStoredEnergy = 0;
        }

        public double TotalMinedCoal
        {
            get
            {
                return this.totalMinedCoal;
            }
            private set
            {
                this.totalMinedCoal = value;
            }
        }
        public double TotalStoredEnergy
        {
            get
            {
                return this.totalStoredEnergy;
            }
            private set
            {
                this.totalStoredEnergy = value;
            }
        }
        public IReadOnlyList<Provider> Providers
        {
            get
            {
                return providers;
            }
        }
        public IReadOnlyList<Miner> Miners
        {
            get
            {
                return miners;
            }

        }

        public string RegisterMiner(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double coalOutput = double.Parse(arguments[2]);
            double energyRequirement = double.Parse(arguments[3]);
            Miner miner = null;

            if(type == "Hewer")
            {
                int enduranceFactor = int.Parse(arguments[4]);
                miner = new Hewer(energyRequirement, coalOutput, id, enduranceFactor);
            }
            else if(type == "Driller")
            {
                miner = new Driller(energyRequirement, coalOutput, id);
            }

            this.miners.Add(miner);

            return $"Successfully registered {type} Miner - {id}";
        }
        public string RegisterProvider(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);
            Provider provider = null;

            if(type == "Sun")
            {
                provider = new SunProvider(energyOutput, id);
            }
            else if(type == "Electricity")
            {
                provider = new ElectricityProvider(energyOutput, id);
            }

            this.providers.Add(provider);

            return $"Successfully registered {type} Provider - {id}";
        }
        public string Day()
        {

            double summedEnergyOutput = providers.Sum(x => x.EnergyOutput);
            this.TotalStoredEnergy += summedEnergyOutput;

            double totalRequirtEnergy = miners.Sum(x => x.EnergyRequirement);
            double summedCoalOutput = 0;

            if(totalRequirtEnergy <= this.TotalStoredEnergy)
            {
                summedCoalOutput += miners.Sum(x => x.CoalOutput);
                this.TotalStoredEnergy -= totalRequirtEnergy;
                this.TotalMinedCoal += summedCoalOutput;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {summedEnergyOutput}");
            sb.AppendLine($"Mined Coal: {summedCoalOutput}");

            return sb.ToString().Trim();
        }
        public string Check(List<string> arguments)
        {
            string id = arguments[0];

            //miners
            int index = this.miners.FindIndex(x => x.Id == id);
            if(index >= 0)
            {
                return this.miners[index].ToString();
            } 

            //providers
            index = this.providers.FindIndex(x => x.Id == id);
            if(index >= 0)
            {
                return this.providers[index].ToString();
            }

            //none
            return $"No element found with id – {id}";
        }
        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
            sb.AppendLine($"Total Mined Coal: {this.totalMinedCoal}");

            return sb.ToString().Trim();
        }
    }
}
