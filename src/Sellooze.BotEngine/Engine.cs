using Binance.Net;
using Binance.Net.Objects.Spot;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using Newtonsoft.Json;
using Sellooze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Websocket.Client;

namespace Sellooze.BotEngine
{
    public class Engine
    {
        private BinanceClient _binanceClient;

        public SelloozeEngineParameters SellozeEngineParameters { get; set; }

        private List<double> Closes { get; set; }
        private List<double> Bought { get; set; }
        private List<double> Sold { get; set; }

        public delegate void MessageReceivedHandler(SelloozeProgressDto progress);
        public event MessageReceivedHandler RaiseReceivedEvent;

        public Engine()
        {
            Closes = new List<double>();
            Bought = new List<double>();
            Sold = new List<double>();

            BinanceClient.SetDefaultOptions(new BinanceClientOptions()
            {
                ApiCredentials = new ApiCredentials("aUOUhXMI7kcGVk71TsSmAzsNbdVBGNe76JsIeQffsfPOhex58UQIS9EklEX3IVFb", "uZwXTuAExVLkrArcSVLb6WqTnp8YGt9ke5bXcdXib6L1CRa2Y5wAITetjuvq1JpT"),
                LogVerbosity = LogVerbosity.Debug
            });

            _binanceClient = new BinanceClient();
        }

        public async Task Run()
        {
            var exitEvent = new ManualResetEvent(false);
            var url = new Uri("wss://stream.binance.com:9443/ws/ethusdt@kline_1m");

            using (var client = new WebsocketClient(url))
            {
                client.ReconnectTimeout = TimeSpan.FromSeconds(30);
                client.ReconnectionHappened.Subscribe(info =>
                    Console.WriteLine($"Reconnection happened, type: {info.Type}"));

                client.MessageReceived.Subscribe(async msg => await ReceiveAsync(msg));
                await client.Start();

                exitEvent.WaitOne();
            }
        }

        private async Task ReceiveAsync(ResponseMessage msg)
        {
            var trade = JsonConvert.DeserializeObject<BinanceModel>(msg.Text);

            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "log", Log = $"Update: Close Price: {trade.k.c}" });

            if (SellozeEngineParameters.Engine == BotEngineEnum.RSI)
            {
                //RSIEngine.Run(trade);

                //candle is close?
                if (trade.k.x)
                {
                    var closePrice = Convert.ToDouble(trade.k.c);
                    Closes.Add(closePrice);

                    RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "closecount", CloseCount = Closes.Count });

                    if (Closes.Count > SellozeEngineParameters.RSI_PERIOD)
                    {
                        var rsi = CalculateRsi(Closes.TakeLast(SellozeEngineParameters.RSI_PERIOD));

                        RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "actualrsi", ActualRSI = rsi });

                        if (rsi > SellozeEngineParameters.RSI_OVERBOUGHT)
                        {
                            Sold.Add(SellozeEngineParameters.TRADE_QUANTITY);
                            var orderResult = _binanceClient.Spot.Order.PlaceTestOrder("ETHUSDT", Binance.Net.Enums.OrderSide.Sell, Binance.Net.Enums.OrderType.Market, (decimal?)SellozeEngineParameters.TRADE_QUANTITY);
                            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "soldLog", Sold = Sold.Sum() });
                            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "log", Log = $"SELL!!! SELL!!! SELL!!! - Rsi: {rsi}" });
                        }

                        if (rsi < SellozeEngineParameters.RSI_OVERSOLD)
                        {
                            Bought.Add(SellozeEngineParameters.TRADE_QUANTITY);
                            var orderResult = _binanceClient.Spot.Order.PlaceTestOrder("ETHUSDT", Binance.Net.Enums.OrderSide.Buy, Binance.Net.Enums.OrderType.Market, (decimal?)SellozeEngineParameters.TRADE_QUANTITY);
                            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "boughtLog", Bought = Bought.Sum() });
                            RaiseReceivedEvent(new SelloozeProgressDto() { Operation = "log", Log = $"BUY!!! BUY!!! BUY!!! - Rsi: {rsi}" });
                        }
                    }
                }
            }
        }

        private double CalculateRsi(IEnumerable<double> closePrices)
        {
            var prices = closePrices as double[] ?? closePrices.ToArray();

            double sumGain = 0;
            double sumLoss = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                var difference = prices[i] - prices[i - 1];
                if (difference >= 0)
                {
                    sumGain += difference;
                }
                else
                {
                    sumLoss -= difference;
                }
            }

            if (sumGain == 0) return 0;
            if (Math.Abs(sumLoss) < 1) return 100;

            var relativeStrength = sumGain / sumLoss;

            return 100.0 - (100.0 / (1 + relativeStrength));
        }

    }
}