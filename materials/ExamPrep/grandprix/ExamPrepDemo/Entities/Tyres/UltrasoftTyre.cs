using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        private const string NameOfTyre = "Ultrasoft";
        private const int BlowTyreMinValue = 30;

        private double grip;
        private double degradation;

        public UltrasoftTyre(double hardness, double grip)
            : base(NameOfTyre, hardness)
        {
            this.Grip = grip;
        }

        public double Grip
        {
            get { return this.grip; }
            set { this.grip = value; }
        }

        public override double Degradation
        {
            get { return this.degradation; }
            protected set
            {
                if (value <= BlowTyreMinValue)
                {
                    throw new ArgumentException();
                }

                this.degradation = value;
            }
        }

        public override void DegradateTyre()
        {
            base.DegradateTyre();
            this.Degradation -= this.Grip;
        }
    }
}
