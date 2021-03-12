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
            consoleBotEngine.Symbols.Add("ethereum");
            consoleBotEngine.Symbols.Add("dogecoin");
            consoleBotEngine.Run();
            
            Console.ReadLine();
        }
    }
}