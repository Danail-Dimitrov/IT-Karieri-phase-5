using MiningSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class Engine : IEngine
    {
        private SystemManager manager;
        private StringBuilder stringBuilder;

        public Engine(SystemManager manager)
        {
            this.manager = manager;
            this.stringBuilder = new StringBuilder();
        }

        public void Run()
        {
            List<string> commandArgs = Console.ReadLine()
                    .Split(" ")
                    .ToList();
            
            string result = null;

            while (commandArgs[0] != "Shutdown")
            {
                string command = commandArgs[0];

                commandArgs.RemoveAt(0);

                try
                {
                    switch (command)
                    {
                        case "RegisterMiner":
                            result = this.manager.RegisterMiner(commandArgs);
                            break;
                        case "RegisterProvider":
                            result = this.manager.RegisterProvider(commandArgs);
                            break;
                        case "Day":
                            result = this.manager.Day();
                            break;
                        case "Check":
                            result = this.manager.Check(commandArgs);
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    result = ex.Message;
                }

                stringBuilder.AppendLine(result);

                commandArgs = Console.ReadLine()
                    .Split(" ")
                    .ToList();
            }

            this.stringBuilder.AppendLine(this.manager.ShutDown());

            Console.WriteLine(stringBuilder.ToString().Trim());
        }
    }
}
