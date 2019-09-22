using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return "Dog";
        }
    }
}
