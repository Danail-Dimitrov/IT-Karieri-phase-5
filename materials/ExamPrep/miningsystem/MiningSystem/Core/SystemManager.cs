using MiningSystem.Core.Contracts;
using MiningSystem.Entities.Miners;
using MiningSystem.Entities.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class SystemManager : ISystemManager
    {
        private MinerFarctory minerFarctory;
        private List<Miner> miners;
        private List<Provider> providers;
        private double totalEnergy;
        private double totalCoalCollected;

        public SystemManager()
        {
            this.miners = new List<Miner>();
            this.providers = new List<Provider>();
            this.minerFarctory = new MinerFarctory();
            this.totalEnergy = 0;
        }


        public string Check(List<string> arguments)
        {
            string id = arguments[0];

            Provider provider = this.providers.FirstOrDefault(x => x.Id == id);

            if (provider == null)
            {
                Miner miner = miners.FirstOrDefault(x => x.Id == id);

                if (miner == null)
                {
                    return $"No element found with id – {id}";
                }

                return miner.ToString();
            }

            return provider.ToString();
        }

        public string Day()
        {
            double energyCollected = 0;

            foreach (var provider in providers)
            {
                energyCollected += provider.EnergyOutput;
            }

            this.totalEnergy += energyCollected;

            double totalRequiredEnergy = 0;

            foreach (var miner in miners)
            {
                totalRequiredEnergy += miner.EnergyRequirement;
            }

            double coalCollected = 0;

            if (totalRequiredEnergy <= totalEnergy)
            {
                foreach (var miner in miners)
                {
                    coalCollected += miner.CoalOutput;
                }

                totalEnergy -= totalRequiredEnergy;
                totalCoalCollected += coalCollected;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {energyCollected}");
            sb.AppendLine($"Mined Coal: {coalCollected}");

            return sb.ToString().Trim();

        }

        public string RegisterMiner(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            string errorMessage = "Miner is not registered, because of it's {0}";

            Miner miner = null;

            try
            {
                miner = MinerFarctory.CreateMiner(arguments);
            }
            catch (ArgumentException ex)
            {
                errorMessage = string.Format(errorMessage, ex.Message);
            }

            if (miner != null)
            {
                this.miners.Add(miner);
                return $"Successfully registered {type} Miner - {id}";
            }

            return errorMessage;
        }

        public string RegisterProvider(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);

            string errorMessage = "Provider is not registered, because of it's {0}";

            Provider provider = null;

            try
            {
                if (type == "Sun")
                {
                    provider = new SunProvider(id, energyOutput);
                }
                else if (type == "Electricity")
                {
                    provider = new ElectricityProvider(id, energyOutput);
                }
            }
            catch (ArgumentException ex)
            {
                errorMessage = string.Format(errorMessage, ex.Message);
            }

            if (provider != null)
            {
                this.providers.Add(provider);
                return $"Successfully registered {type} Provider - {id}";
            }

            return errorMessage;

        }

        public string ShutDown()
        {
            //“System Shutdown
            // Total Energy Stored: { totalEnergyStored}
            //Total Mined Coal: { totalMinedCoal}”.

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: {totalEnergy}");
            sb.AppendLine($"Total Mined Coal: {totalCoalCollected}");

            return sb.ToString().Trim();
        }
    }
}
