using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrepDemo.Entities.Tyres
{
    public class HardTyre : Tyre
    {
        private const string NameOfTyre = "Hard";

        public HardTyre(double hardness)
            :base(NameOfTyre, hardness)
        {
        }
    }
}
