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
            return 2 * Math.PI * base.Size;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
