using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public override string ToString()
        {
            return $"{this}[{animalName} {";
        }
    }
}
