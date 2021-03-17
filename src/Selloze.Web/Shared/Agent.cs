using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selloze.Web.Shared
{
    public class Agent
    {

        public Guid ID { get; set; }

        public string User { get; set; }

        public string AgentCode { get; set; }

        public DateTime LastActivity { get; set; }

    }
}
