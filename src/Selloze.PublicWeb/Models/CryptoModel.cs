using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selloze.PublicWeb
{
    public class CryptoModel
    {
        public List<Datum> Data { get; set; }
        public long timestamp { get; set; }

        public class Datum
        {
            public string id { get; set; }
            public string rank { get; set; }
            public string symbol { get; set; }
            public string name { get; set; }
            public double? supply { get; set; }
            public double? maxSupply { get; set; }
            public double? marketCapUsd { get; set; }
            public double? volumeUsd24Hr { get; set; }
            public double? priceUsd { get; set; }
            public double? changePercent24Hr { get; set; }
            public double? vwap24Hr { get; set; }

            public string supplyStr { get; set; }
            public string maxSupplyStr { get; set; }
            public string marketCapUsdStr { get; set; }
            public string volumeUsd24HrStr { get; set; }
            public string priceUsdStr { get; set; }
            public string changePercent24HrStr { get; set; }
            public string vwap24HrStr { get; set; }
        }
    }

}
