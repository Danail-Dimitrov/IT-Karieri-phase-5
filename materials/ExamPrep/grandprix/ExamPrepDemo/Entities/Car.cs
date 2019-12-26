using ExamPrepDemo.Entities.Tyres;
using System;

namespace ExamPrepDemo.Entities
{
    public class Car
    {
        private const int FuelMaxCapacity = 160;
        private const int FuelMinCapacity = 0;

        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(int hp , double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp
        {
            get { return hp; }
            private set { hp = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set
            {
                if (value < FuelMinCapacity)
                {
                    throw new ArgumentException("Out of fuel");
                }

                if (value > FuelMaxCapacity)
                {
                    this.fuelAmount = FuelMaxCapacity;
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }

        public Tyre Tyre
        {
            get { return tyre; }
            set { tyre = value; }
        }

    }
}
