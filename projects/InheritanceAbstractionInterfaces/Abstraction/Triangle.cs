using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, int size) : base(color, size)
        {
        }

        public override double GetAreal()
        {
            double pow = Math.Pow(Size, 2);
            double sqrt = Math.Sqrt(3);
            return (pow * sqrt) / 4;
        }

        public override string GetName()
        {         
            return "Triangle";
        }
    }
}
