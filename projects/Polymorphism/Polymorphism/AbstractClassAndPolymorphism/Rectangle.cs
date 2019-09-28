using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndPolymorphism
{
    class Rectangle : Shape
    {
        private double hight;
        private double width;

        public Rectangle(double hight, double width)
        {
            this.hight = hight;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return hight * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (hight + width);
        }

        public override string Draw()
        {
            return "drawing... rectangle";
        }
    }
}
