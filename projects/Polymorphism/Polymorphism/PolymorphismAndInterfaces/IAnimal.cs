using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAndInterfaces
{
    interface IAnimal : IMakeNoise, IMakeTrick
    {
        string Perform();
    }
}
