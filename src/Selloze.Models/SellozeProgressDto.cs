using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selloze.Models
{
    public class SellozeProgressDto
    {

        public string Operation { get; set; }

        public string Log { get; set; }

        public double ActualRSI { get; set; }

        public int CloseCount { get; set; }
    }
}
