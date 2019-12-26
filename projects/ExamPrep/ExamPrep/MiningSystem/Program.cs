using MiningSystem.Core;
using System;

namespace MiningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //MiningSystem is finished passed the provided test
            SystemManager systemManager = new SystemManager();
            Engine engine = new Engine(systemManager);
            engine.Run();
        }
    }
}
