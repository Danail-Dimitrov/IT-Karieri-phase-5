using System;

namespace EventRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string command = Console.ReadLine();
            while(command != "End")
            {
                dispatcher.Name = command;
                command = Console.ReadLine();
            }
        }
    }
}
