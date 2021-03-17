using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selloze.Models
{
    public class SellozeEngineParameters
    {
        public List<string> Symbols { get; set; }

        public int RSI_PERIOD { get; set; }// = 14;
        public int RSI_OVERBOUGHT { get; set; }// = 70;
        public int RSI_OVERSOLD { get; set; }// = 30;
        public double TRADE_QUANTITY { get; set; } // 0.05;

        public SellozeEngineParameters()
        {
            Symbols = new List<string>();
        }
    }
}
