using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class ColoredFigure
    {
        private string color;
        private int size;

        protected ColoredFigure(string color, int size)
        {
            Color = color;
            Size = size;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }
        public int Size
        {
            get => size;
            set => size = value;
        }

        public void Show()
        {
            Console.WriteLine($"{color} {size}");
        }

        public abstract string GetName();

        public abstract double GetAreal();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetName()}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Size: {Size}");
            sb.Append("Area:");
            double d = GetAreal();
            sb.AppendFormat("{0:f2}", d);
            return sb.ToString();
        }
    }
}
