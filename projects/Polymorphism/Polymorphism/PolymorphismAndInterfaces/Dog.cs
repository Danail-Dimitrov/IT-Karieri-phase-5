using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAndInterfaces
{
    class Dog : IAnimal
    {
        public string MakeNose()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human";
        }

        public string Perform()
        {
            string a = MakeNose();
            a += MakeTrick();
            return a;
        }
    }
}
