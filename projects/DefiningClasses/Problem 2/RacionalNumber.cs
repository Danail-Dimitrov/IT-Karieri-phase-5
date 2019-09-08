using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class RacionalNumber
    {
        private int numerator;
        private int denumerator;

        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }
        public int Denumerator
        {
            get => denumerator;
            set => denumerator = value;
        }

        public override string ToString()
        {
            return $"{numerator}/{denumerator}";
        }
    }
}
