using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPrepDemo.Core
{
    public class Engine
    {
        private RaceTower raceTower;

        public Engine(RaceTower raceTower)
        {
            this.raceTower = raceTower;
        }

        public void Run()
        {
            int laps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());

            this.raceTower.SetTrackInfo(laps, trackLength);

            string winnerResult = null;

            while (this.raceTower.HasWinner == false)
            {
                List<string> commandArgs = Console.ReadLine()
                    .Split(" ")
                    .ToList();

                string command = commandArgs[0];

                try
                {
                    switch (command)
                    {
                        case "RegisterDriver":
                            raceTower.RegisterDriver(commandArgs.Skip(1).ToList());
                            break;
                        case "Leaderboard":
                            Console.WriteLine(raceTower.GetLeaderboard());
                            break;
                        case "CompleteLaps":
                            winnerResult = raceTower.CompleteLaps(commandArgs.Skip(1).ToList());
                            break;
                        case "Box":
                            raceTower.DriverBoxes(commandArgs.Skip(1).ToList());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(winnerResult);
        }
    }
}
