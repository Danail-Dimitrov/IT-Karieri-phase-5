using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Circle : ColoredFigure
    {
        public Circle(string color, int size) : base(color, size)
        {
        }

        public override double GetAreal()
        {
            return Math.PI * base.Size * base.Size;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
