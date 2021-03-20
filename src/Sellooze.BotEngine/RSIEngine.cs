using Sellooze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellooze.BotEngine
{
    public class RSIEngine
    {
    //    internal static void Run(BinanceModel trade)
    //    {
    //        //candle is close?
    //        if (trade.k.x)
    //        {
    //            var closePrice = Convert.ToDouble(trade.k.c);
    //            Closes.Add(closePrice);

    //            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "closecount", CloseCount = Closes.Count });

    //            if (Closes.Count > SellozeEngineParameters.RSI_PERIOD)
    //            {
    //                var rsi = CalculateRsi(Closes.TakeLast(SellozeEngineParameters.RSI_PERIOD));

    //                RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "actualrsi", ActualRSI = rsi });

    //                if (rsi > SellozeEngineParameters.RSI_OVERBOUGHT)
    //                {
    //                    Sold.Add(SellozeEngineParameters.TRADE_QUANTITY);
    //                    RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "soldLog", Sold = Sold.Sum() });
    //                    RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "log", Log = $"SELL!!! SELL!!! SELL!!! - Rsi: {rsi}" });
    //                }

    //                if (rsi < SellozeEngineParameters.RSI_OVERSOLD)
    //                {
    //                    Bought.Add(SellozeEngineParameters.TRADE_QUANTITY);
    //                    RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "boughtLog", Bought = Bought.Sum() });
    //                    RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "log", Log = $"BUY!!! BUY!!! BUY!!! - Rsi: {rsi}" });
    //                }
    //            }
    //        }
    //    }
    //}

    //private double CalculateRsi(IEnumerable<double> closePrices)
    //{
    //    var prices = closePrices as double[] ?? closePrices.ToArray();

    //    double sumGain = 0;
    //    double sumLoss = 0;
    //    for (int i = 1; i < prices.Length; i++)
    //    {
    //        var difference = prices[i] - prices[i - 1];
    //        if (difference >= 0)
    //        {
    //            sumGain += difference;
    //        }
    //        else
    //        {
    //            sumLoss -= difference;
    //        }
    //    }

    //    if (sumGain == 0) return 0;
    //    if (Math.Abs(sumLoss) < 1) return 100;

    //    var relativeStrength = sumGain / sumLoss;

    //    return 100.0 - (100.0 / (1 + relativeStrength));
    //}
}
