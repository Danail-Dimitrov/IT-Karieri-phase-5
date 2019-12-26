using MiningSystem.Core;
using MiningSystem.Entities.Providers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MiningSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
