using MiningSystem.Entities.Miners;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Core
{
    public class MinerFarctory
    {
        public static Miner CreateMiner(List<string> arguments)
        {
            Miner miner = null;

            string type = arguments[0];
            string id = arguments[1];
            double coalOutput = double.Parse(arguments[2]);
            double energyRequirements = double.Parse(arguments[3]);

            if (type == "Hewer")
            {
                int enduranceFactor = int.Parse(arguments[4]);

                miner = new Hewer(id, coalOutput, energyRequirements, enduranceFactor);
            }
            else if (type == "Driller")
            {
                miner = new Driller(id, coalOutput, energyRequirements);
            }

            return miner;
        }
    }
}
