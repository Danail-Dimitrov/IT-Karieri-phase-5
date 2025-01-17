﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndPolymorphism
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "drawing... Shape";
        }
    }
}
