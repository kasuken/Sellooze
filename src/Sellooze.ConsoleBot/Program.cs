using Sellooze.Models;
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
            var consoleBotEngine = new Sellooze.BotEngine.Engine();

            var sellozeEngineParameters = new Sellooze.Models.SelloozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");
            sellozeEngineParameters.RSI_PERIOD = 3;
            sellozeEngineParameters.RSI_OVERBOUGHT = 70;
            sellozeEngineParameters.RSI_OVERSOLD = 30;
            sellozeEngineParameters.TRADE_QUANTITY = 0.005;

            consoleBotEngine.SellozeEngineParameters = sellozeEngineParameters;

            _ = consoleBotEngine.Run();
            
            Console.ReadLine();
        }
    }
}