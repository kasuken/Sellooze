using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Selloze.ConsoleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleBotEngine = new ConsoleBotEngine.Engine();

            var sellozeEngineParameters = new Models.SellozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");
            sellozeEngineParameters.RSI_PERIOD = 3;
            sellozeEngineParameters.RSI_OVERBOUGHT = 70;
            sellozeEngineParameters.RSI_OVERSOLD = 30;

            consoleBotEngine.SellozeEngineParameters = sellozeEngineParameters;

            consoleBotEngine.Run();
            
            Console.ReadLine();
        }
    }
}