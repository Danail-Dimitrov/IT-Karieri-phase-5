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
            return (Math.Pow(base.Size, 2) * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            
            return "Triangle";
        }
    }
}
