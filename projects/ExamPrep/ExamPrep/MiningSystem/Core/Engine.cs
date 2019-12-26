using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class Engine
    {
        private SystemManager systemManager;

        public Engine(SystemManager systemManager)
        {
            this.SystemManager = systemManager;
        }

        public SystemManager SystemManager
        {
            get
            {
                return systemManager;
            }
            set
            {
                systemManager = value;
            }
        }

        public void Run()
        {
            List<string> commandArgs = Console.ReadLine().Split(' ').ToList();
            string command = commandArgs[0];

            StringBuilder sb = new StringBuilder();

            while(command != "Shutdown")
            {
                commandArgs.Remove(command);                

                try
                {
                    switch(command)
                    {
                        case "RegisterMiner":
                            sb.AppendLine(this.SystemManager.RegisterMiner(commandArgs));
                            break;
                        case "RegisterProvider":
                            sb.AppendLine(this.SystemManager.RegisterProvider(commandArgs));
                            break;
                        case "Day":
                            sb.AppendLine(this.SystemManager.Day());
                            break;
                        case "Check":
                            sb.AppendLine(this.SystemManager.Check(commandArgs));
                            break; 
                    }
                }
                catch(InvalidOperationException ex)
                {
                    sb.AppendLine(ex.Message);
                }

                commandArgs = Console.ReadLine().Split(' ').ToList();
                command = commandArgs[0];
            }

            sb.AppendLine(this.SystemManager.Shutdown());

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
