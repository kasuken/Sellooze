using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sellooze.PublicWeb
{
    public class CoinDetail
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

        [JsonProperty("id")]
        public string PurpleId { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("cap24hrChange")]
        public double Cap24HrChange { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("supply")]
        public long Supply { get; set; }

        public string SupplyFormat { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("vwap_h24")]
        public double VwapH24 { get; set; }

        [JsonProperty("price_btc")]
        public double PriceBtc { get; set; }

        [JsonProperty("price_eth")]
        public double PriceEth { get; set; }

        [JsonProperty("price_eur")]
        public double PriceEur { get; set; }

        [JsonProperty("price_usd")]
        public double PriceUsd { get; set; }

        [JsonProperty("price_ltc")]
        public double PriceLtc { get; set; }

        [JsonProperty("price_zec")]
        public double PriceZec { get; set; }

        [JsonProperty("market_cap")]
        public double MarketCap { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        public string PriceFormat { get; set; }

        public string MktcapDollar { get; set; }

        public string VolumeDollar { get; set; }
    }
}
