using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grid.Core
{
    public class Engine
    {
        private RaceTower raceTower;

        public Engine(RaceTower raceTower)
        {
            RaceTower = raceTower;
        }

        public RaceTower RaceTower
        {
            get
            {
                return raceTower;
            }
            set
            {
                raceTower = value;
            }
        }

        public void Run()
        {
            int laps =int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            RaceTower.SetTrackInfo(laps, lenght);

            List<string> commandArgs = Console.ReadLine().Split(' ').ToList();
            string command = commandArgs[0];

            StringBuilder sb = new StringBuilder();
            string winnerMessege = null;

            while(!raceTower.HasWinner)
            {
                commandArgs.Remove(command);

                try
                {
                    switch(command)
                    {
                        case "RegisterDriver":
                            RaceTower.RegisterDriver(commandArgs);
                            break;
                        case "Leaderboard":
                            sb.AppendLine(RaceTower.GetLeaderboard());
                            break;
                        case "CompleteLaps":
                            winnerMessege = RaceTower.CompleteLaps(commandArgs);
                            break;
                        case "Box":
                            RaceTower.DriverBoxes(commandArgs);
                            break;
                    }

                }
                catch(Exception ex)
                {
                    sb.AppendLine(ex.Message);
                }
                
                commandArgs = Console.ReadLine().Split(' ').ToList();
                command = commandArgs[0];
            }

            sb.AppendLine(winnerMessege);

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
