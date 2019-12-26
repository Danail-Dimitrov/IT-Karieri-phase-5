namespace MiningSystem.Entities.Miners
{
    public class Hewer : Miner
    {
        private int enduranceFactor;

        public Hewer(string id, double coalOutput, double energyRequirement, int enduranceFactor)
            :base(id, coalOutput, energyRequirement)
        {
            this.EnduranceFactor = enduranceFactor;
            base.EnergyRequirement = base.EnergyRequirement / this.EnduranceFactor;
        }

        public int EnduranceFactor
        {
            get { return enduranceFactor; }
            set { enduranceFactor = value; }
        }
    }
}
