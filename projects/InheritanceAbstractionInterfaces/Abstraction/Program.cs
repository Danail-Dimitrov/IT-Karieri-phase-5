using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFigures = int.Parse(Console.ReadLine());

            List<ColoredFigure> list = new List<ColoredFigure>();

            for(int i = 1 ; i <= numberOfFigures ; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
                switch(commandArgs[0])
                {
                    case "Triangle":
                        Triangle triangle = new Triangle(commandArgs[1],int.Parse(commandArgs[2]));

                        list.Add(triangle);
                        break;
                    case "Circle":
                        Circle circle = new Circle(commandArgs[1], int.Parse(commandArgs[2]));

                        list.Add(circle);
                        break;
                    case "Square":
                        Square square = new Square(commandArgs[1], int.Parse(commandArgs[2]));

                        list.Add(square);
                        break;
                }            
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
