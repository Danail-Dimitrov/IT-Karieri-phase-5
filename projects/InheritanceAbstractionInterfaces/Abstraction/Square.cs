using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : ColoredFigure
    {
        public Square(string color, int size) : base(color, size)
        {
        }

        public override double GetAreal()
        {
            return base.Size * base.Size;
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
