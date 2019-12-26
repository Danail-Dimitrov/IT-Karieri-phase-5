using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public class UltrasoftTyre : Tyre
    {
        private const string NameOfTyre = "Ultrasoft";
        private const int BlowTyreMinValue = 30;

        private double grip;

        public UltrasoftTyre(double hardness, double grip) : base(hardness, NameOfTyre)
        {
            Grip = grip;
        }

        public double Grip
        {
            get
            {
                return grip;
            }
            private set
            {
                grip = value;
            }
        }

        public override double Degradation
        {
            get
            {
               return base.Degradation;
            }
            protected set
            {
                if(value <= BlowTyreMinValue)
                {
                    throw new ArgumentException("Blow Tyre");
                }

                base.Degradation = value;
            }
        }

        public override void Degrade()
        {
            base.Degrade();
            base.Degradation -= Grip;
        }
    }
}
