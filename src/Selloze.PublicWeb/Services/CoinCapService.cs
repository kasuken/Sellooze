using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Selloze.PublicWeb
{
    public class CoinCapService : ICoinCapService
    {
        const string baseAddress = "https://api.coincap.io";

        public async Task<CryptoModel> RetrieveFrontValues()
        {
            var cryptoModel = new CryptoModel();

            using (var httpClient = new HttpClient())
            {
                var frontInfo = await httpClient.GetStringAsync($"{baseAddress}/v2/assets");

                cryptoModel = JsonConvert.DeserializeObject<CryptoModel>(frontInfo);
            }

            foreach (var item in cryptoModel.Data)
            {
                item.marketCapUsdStr = item.marketCapUsd.Value.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                item.priceUsdStr = item.priceUsd.Value.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                item.volumeUsd24HrStr = item.volumeUsd24Hr.Value.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));

                item.supplyStr = item.supply.Value.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
                item.changePercent24HrStr = item.changePercent24Hr.Value.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
            }

            return cryptoModel;
        }

        public async Task<GlobalData> RetrieveGlobalData()
        {
            var data = new GlobalData();

            //using (var httpClient = new HttpClient())
            //{
            //    var dataInfo = await httpClient.GetStringAsync($"{baseAddress}/global");

            //    data = JsonConvert.DeserializeObject<GlobalData>(dataInfo);
            //}

            return data;
        }

        public async Task<CoinDetail> RetrieveCoinDetails(string coin)
        {
            var coinDetail = new CoinDetail();

            using (var httpClient = new HttpClient())
            {
                var coinInfo = await httpClient.GetStringAsync($"{baseAddress}/page/{coin}");

                coinDetail = JsonConvert.DeserializeObject<CoinDetail>(coinInfo);

                coinDetail.SupplyFormat = coinDetail.Supply.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
                coinDetail.PriceFormat = coinDetail.Price.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                coinDetail.MktcapDollar = coinDetail.MarketCap.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
                coinDetail.VolumeDollar = coinDetail.Volume.ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
            }

            return coinDetail;
        }

        public async Task<CoinHistory> RetrieveCoinHistory(string coin, int days)
        {
            var history = new CoinHistory();

            using (var httpClient = new HttpClient())
            {
                var historyInfo = string.Empty;

                if (days == 0)
                {
                    historyInfo = await httpClient.GetStringAsync($"{baseAddress}/history/{coin}");
                }
                else
                {
                    historyInfo = await httpClient.GetStringAsync($"{baseAddress}/history/{days}DAY/{coin}");
                }

                history = JsonConvert.DeserializeObject<CoinHistory>(historyInfo);
            }

            return history;
        }
    }
}