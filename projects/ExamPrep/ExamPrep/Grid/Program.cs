using Grid.Core;
using System;

namespace Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceTower raceTower = new RaceTower();
            
            Engine engine = new Engine(raceTower);

            engine.Run();
        }
    }
}
