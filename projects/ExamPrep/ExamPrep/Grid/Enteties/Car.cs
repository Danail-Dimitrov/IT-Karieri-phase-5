using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public class Car
    {
        private const int MaxLitters = 160;

        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(Tyre tyre, double fuelAmount, int hp)
        {
            Tyre = tyre;
            FuelAmount = fuelAmount;
            Hp = hp;
        }

        public Tyre Tyre
        {
            get
            {
                return tyre;
            }
            set
            {
                tyre = value;
            }
        }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Out of fuel");
                }

                if(value > MaxLitters)
                {
                    value = 160;
                }

                fuelAmount = value;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
            protected set
            {
                hp = value;
            }
        }
    }
}
