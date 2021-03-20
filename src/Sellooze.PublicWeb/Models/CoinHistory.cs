using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sellooze.PublicWeb
{
    public class CoinHistory
    {
        [JsonProperty("market_cap")]
        public List<List<long>> MarketCap { get; set; }

        [JsonProperty("price")]
        public List<List<double>> Price { get; set; }

        [JsonProperty("volume")]
        public List<List<long>> Volume { get; set; }
    }
}
