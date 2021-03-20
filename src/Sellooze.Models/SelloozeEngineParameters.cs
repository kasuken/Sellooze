using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellooze.Models
{
    public enum BotEngineEnum
    {
        RSI = 0,
        OTHER = 1
    }

    public class SelloozeEngineParameters
    {
        public List<string> Symbols { get; set; }

        public BotEngineEnum Engine { get; set; }

        public int RSI_PERIOD { get; set; }// = 14;
        public int RSI_OVERBOUGHT { get; set; }// = 70;
        public int RSI_OVERSOLD { get; set; }// = 30;
        public double TRADE_QUANTITY { get; set; } // 0.05;

        public SelloozeEngineParameters()
        {
            Symbols = new List<string>();
        }
    }
}
