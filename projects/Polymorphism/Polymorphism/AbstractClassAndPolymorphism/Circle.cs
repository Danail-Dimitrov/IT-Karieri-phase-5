﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndPolymorphism
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string Draw()
        {
            return "drawing... cirlce";
        }
    }
}
