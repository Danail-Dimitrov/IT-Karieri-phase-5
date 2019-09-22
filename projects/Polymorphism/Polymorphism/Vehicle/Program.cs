using System;
using System.Linq;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //first task pased modifying the code for the 2nd one
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
            double[] parsedArgs = Parse(commandArgs);
            Car car = new Car(parsedArgs[0], parsedArgs[1], parsedArgs[2]);

            commandArgs = Console.ReadLine().Split(' ').ToArray();
            parsedArgs = Parse(commandArgs);
            Truck truck = new Truck(parsedArgs[0], parsedArgs[1], parsedArgs[2]);

            commandArgs = Console.ReadLine().Split(' ').ToArray();
            parsedArgs = Parse(commandArgs);
            Bus bus = new Bus(parsedArgs[0], parsedArgs[1], parsedArgs[2]);

            int n = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < n ; i++)
            {
                commandArgs = Console.ReadLine().Split(' ').ToArray();
                double ammount = double.Parse(commandArgs[2]);
                string toPrint = null;

                switch(commandArgs[0])
                {
                    case "Drive":
                        if(commandArgs[1] == "Car")
                        {
                            toPrint = car.Drive(ammount);
                        }
                        else if(commandArgs[1] == "Truck")
                        {
                            toPrint = truck.Drive(ammount);
                        }
                        else
                        {
                            toPrint = bus.Drive(ammount);
                        }
                        break;
                    case "Refuel":
                        if(commandArgs[1] == "Car")
                        {
                            toPrint = car.Refuel(ammount);
                        }
                        else if(commandArgs[1] == "Truck")
                        {
                            toPrint = truck.Refuel(ammount);
                        }
                        else
                        {
                            toPrint = bus.Refuel(ammount);
                        }
                        break;
                    case "DriveEmpty":
                        toPrint = bus.DriveEmpty(ammount);
                        break;
                }
                PrintAction(toPrint);
            }
            Console.WriteLine("Car: {0:f2}", car.Gas);
            Console.WriteLine("Truck: {0:f2}", truck.Gas);
            Console.WriteLine("Bus: {0:f2}", bus.Gas);
        }

        private static double[] Parse(string[] massive)
        {
            double[] toReturn = new double[massive.Length - 1];

            for(int i = 0 ; i < massive.Length - 1 ; i++)
            {
                toReturn[i] = double.Parse(massive[i + 1]);
            }

            return toReturn;
        }
        private static void PrintAction(string toPrint)
        {
            if(toPrint != "")
            {            
            Console.WriteLine(toPrint);
            }
        }
    }
}
