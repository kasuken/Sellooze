using Coinbase;
using Coinbase.Models;
using Newtonsoft.Json;
using Selloze.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Websocket.Client;

namespace Selloze.ConsoleBotEngine
{
    public class Engine
    {
        public SellozeEngineParameters SellozeEngineParameters { get; set; }

        private List<double> Closes { get; set; }

        public delegate void MessageReceivedHandler(SellozeProgressDto progress);
        public event MessageReceivedHandler RaiseReceivedEvent;

        public Engine()
        {
            Closes = new List<double>();
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

                client.MessageReceived.Subscribe(msg => ReceiveAsync(msg));
                await client.Start();

                exitEvent.WaitOne();
            }
        }

        private async Task ReceiveAsync(ResponseMessage msg)
        {
            var trade = JsonConvert.DeserializeObject<BinanceModel>(msg.Text);

            if (SellozeEngineParameters.Engine == BotEngine.RSI)
            {
                //candle is close?
                if (trade.k.x)
                {
                    var closePrice = Convert.ToDouble(trade.k.c);
                    Closes.Add(closePrice);

                    RaiseReceivedEvent(new SellozeProgressDto() { Operation = "closecount", CloseCount = Closes.Count });

                    if (Closes.Count > SellozeEngineParameters.RSI_PERIOD)
                    {
                        var rsi = CalculateRsi(Closes.TakeLast(SellozeEngineParameters.RSI_PERIOD));

                        RaiseReceivedEvent(new SellozeProgressDto() { Operation = "actualrsi", ActualRSI = rsi });

                        if (rsi > SellozeEngineParameters.RSI_OVERBOUGHT)
                        {
                            RaiseReceivedEvent(new SellozeProgressDto() { Operation = "log", Log = $"SELL!!! SELL!!! SELL!!! - Rsi: {rsi}" });
                        }

                        if (rsi < SellozeEngineParameters.RSI_OVERSOLD)
                        {
                            RaiseReceivedEvent(new SellozeProgressDto() { Operation = "log", Log = $"BUY!!! BUY!!! BUY!!! - Rsi: {rsi}" });
                        }
                    }
                }
            }

            RaiseReceivedEvent(new SellozeProgressDto() { Operation = "log", Log = $"Received: {trade.e} - Close Price: {trade.k.c}" });
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