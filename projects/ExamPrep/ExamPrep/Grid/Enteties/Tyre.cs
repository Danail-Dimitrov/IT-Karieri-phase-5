using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public abstract class Tyre
    {
        private const int DegradationAtStart = 100;
        private const int BlowTyreMinValue = 0;

        private string name;
        private double hardness;
        private double degradation;

        protected Tyre(double hardness, string name)
        {
            Hardness = hardness;
            Name = name;
            Degradation = DegradationAtStart;
        }

        public virtual double Degradation
        {
            get
            {
                return degradation;
            }
            protected set
            {
                if(value <= BlowTyreMinValue)
                {
                    throw new ArgumentException("Blow Tyre");
                }
                degradation = value;
            }
        }
        public double Hardness
        {
            get
            {
                return hardness;
            }
            protected set
            {
                hardness = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        public virtual void Degrade()
        {
            Degradation -= Hardness;
        }
    }
}
