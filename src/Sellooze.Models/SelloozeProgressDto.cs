using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellooze.Models
{
    public class SelloozeProgressDto
    {

        public string Operation { get; set; }

        public string Log { get; set; }

        public double ActualRSI { get; set; }

        public int CloseCount { get; set; }

        public double Bought { get; set; }
        public double Sold { get; set; }
    }
}
