using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sellooze.PublicWeb
{
    public class GlobalData
    {
        [JsonProperty("altCap")]
        public double AltCap { get; set; }

        [JsonProperty("bitnodesCount")]
        public long BitnodesCount { get; set; }

        [JsonProperty("btcCap")]
        public double BtcCap { get; set; }

        [JsonProperty("btcPrice")]
        public double BtcPrice { get; set; }

        [JsonProperty("dom")]
        public double Dom { get; set; }

        [JsonProperty("totalCap")]
        public double TotalCap { get; set; }

        [JsonProperty("volumeAlt")]
        public double VolumeAlt { get; set; }

        [JsonProperty("volumeBtc")]
        public double VolumeBtc { get; set; }

        [JsonProperty("volumeTotal")]
        public double VolumeTotal { get; set; }
    }
}
