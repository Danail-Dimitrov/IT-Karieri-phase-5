using ExamPrepDemo.Core;
using System;

namespace ExamPrepDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTower race = new RaceTower();

            Engine engine = new Engine(race);
            engine.Run();
        }
    }
}
