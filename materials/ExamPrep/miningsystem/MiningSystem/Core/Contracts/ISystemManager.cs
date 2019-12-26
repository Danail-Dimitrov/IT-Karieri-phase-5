using System.Collections.Generic;

namespace MiningSystem.Core.Contracts
{
    public interface ISystemManager
    {
        string RegisterMiner(List<string> arguments);

        string RegisterProvider(List<string> arguments);

        string Day();

        string Check(List<string> arguments);

        string ShutDown();
    }
}
