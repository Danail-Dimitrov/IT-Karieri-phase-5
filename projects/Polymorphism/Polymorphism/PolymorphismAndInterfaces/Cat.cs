using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAndInterfaces
{
    class Cat : IAnimal
    {
        public string MakeNose()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
           return "No trick for you! I'm too lazy!";
        }

        public string Perform()
        {
            
        }
    }
}
