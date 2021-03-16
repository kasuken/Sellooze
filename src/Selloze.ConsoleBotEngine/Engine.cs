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
        private Coinbase.CoinbaseClient CoinbaseClient { get; set; }

        public SellozeEngineParameters SellozeEngineParameters { get; set; }

        //public List<string> Symbols { get; set; }

        private List<double> Closes { get; set; }

        public delegate void MessageReceivedHandler(SellozeProgressDto progress);

        public event MessageReceivedHandler RaiseReceivedEvent;

        public Engine()
        {
            Closes = new List<double>();
        }

        public async Task Run()
        {
            // var spot = await CoinbaseClient.Data.GetSpotPriceAsync("ETH-USD");
            // var payments = await CoinbaseClient.PaymentMethods.ListPaymentMethodsAsync();

            //var accounts = await CoinbaseClient.Accounts.ListAccountsAsync();

            //var create = new PlaceBuy
            //{
            //    Amount = 000.1m,
            //    Currency = "BTC",
            //    PaymentMethod = "B28EB04F-BD70-4308-90A1-96065283A001"
            //};
            //var r = await CoinbaseClient.Buys.PlaceBuyOrderAsync(accounts.Data[0].Id, create);

            var exitEvent = new ManualResetEvent(false);
            var url = new Uri("wss://stream.binance.com:9443/ws/ethusdt@kline_1m");

            using (var client = new WebsocketClient(url))
            {
                client.ReconnectTimeout = TimeSpan.FromSeconds(30);
                client.ReconnectionHappened.Subscribe(info =>
                    Console.WriteLine($"Reconnection happened, type: {info.Type}"));

                client.MessageReceived.Subscribe(msg => Receive(msg));
                await client.Start();

                exitEvent.WaitOne();
            }
        }

        private async Task Receive(ResponseMessage msg)
        {
            var trade = JsonConvert.DeserializeObject<BinanceModel>(msg.Text);

            //candle is close?
            if (trade.k.x)
            {
                var closePrice = Convert.ToDouble(trade.k.c);
                Closes.Add(closePrice);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Close!!! Closes:{Closes.Count}");
                Console.ForegroundColor = ConsoleColor.White;

                RaiseReceivedEvent(new SellozeProgressDto() { Operation = "closecount", CloseCount = Closes.Count });

                if (Closes.Count > SellozeEngineParameters.RSI_PERIOD)
                {
                    var rsi = CalculateRsi(Closes.TakeLast(SellozeEngineParameters.RSI_PERIOD));

                    RaiseReceivedEvent(new SellozeProgressDto() { Operation = "actualrsi", ActualRSI = rsi });

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"RSI: {rsi}");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (rsi > SellozeEngineParameters.RSI_OVERBOUGHT)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("SELL!!! SELL!!! SELL!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (rsi < SellozeEngineParameters.RSI_OVERSOLD)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("BUY!!! BUY!!! BUY!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            RaiseReceivedEvent(new SellozeProgressDto() { Operation = "log", Log = $"Received: {trade.e} - Close Price: {trade.k.c}" });

            Console.WriteLine($"Received: {trade.e} - Close Price: {trade.k.c}");
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
            //if (Math.Abs(sumLoss) < Tolerance) return 100;
            if (Math.Abs(sumLoss) < 10) return 100;

            var relativeStrength = sumGain / sumLoss;

            return 100.0 - (100.0 / (1 + relativeStrength));
        }

    }
}