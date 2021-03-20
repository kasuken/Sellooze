﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sellooze.PublicWeb
{
    public interface ICoinCapService
    {
        Task<CoinDetail> RetrieveCoinDetails(string coin);
        Task<CoinHistory> RetrieveCoinHistory(string coin, int days);
        Task<CryptoModel> RetrieveFrontValues();
        Task<GlobalData> RetrieveGlobalData();
    }
}
