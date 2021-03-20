using System;
using Newtonsoft.Json;

namespace Sellooze.Models
{
    public partial class Trade
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("quote")]
        public string Quote { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("priceUsd")]
        public double PriceUsd { get; set; }
    }
}