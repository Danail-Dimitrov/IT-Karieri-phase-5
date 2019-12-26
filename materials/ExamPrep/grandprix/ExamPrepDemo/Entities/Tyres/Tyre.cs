using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Tyres
{
    public abstract class Tyre
    {
        private const int InitialDegradation = 100;
        private const int BlowTyreMinValue = 0;

        private string name;
        private double hardness;
        private double degradation;

        protected Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = InitialDegradation;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public double Hardness
        {
            get { return this.hardness; }
            private set { this.hardness = value; }
        }

        public virtual double Degradation
        {
            get { return this.degradation; }
            protected set
            {
                if (value <= BlowTyreMinValue)
                {
                    throw new ArgumentException("Blow Tyre");
                }

                this.degradation = value;
            }
        }

        public virtual void DegradateTyre()
        {
           this.Degradation -= this.Hardness;
        }
    }
}
