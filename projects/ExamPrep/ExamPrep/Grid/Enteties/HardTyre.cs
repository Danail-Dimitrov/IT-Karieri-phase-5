using System;
using System.Collections.Generic;
using System.Text;

namespace Grid.Enteties
{
    public class HardTyre : Tyre
    {
        private const string NameOfTyre = "Hard";

        public HardTyre(double hardness) : base(hardness, NameOfTyre)
        {
        }
    }
}
