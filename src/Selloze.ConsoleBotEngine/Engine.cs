using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Selloze.Models;
using Websocket.Client;

namespace Selloze.ConsoleBotEngine
{
    public class Engine
    {

        public List<string> Symbols { get; set; }

        public Engine()
        {
            Symbols = new List<string>();
        }
        
        public async Task Run()
        {
            var exitEvent = new ManualResetEvent(false);
            // var url = new Uri("wss://ws.coincap.io/trades/binance");
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
            // var trade = JsonConvert.DeserializeObject<Trade>(msg.Text);
            //
            // if (Symbols.Contains(trade.Base))
            // {
            //     Console.WriteLine($"{trade.Base} > {trade.Direction}");
            // }

            var trade = JsonConvert.DeserializeObject<BinanceModel>(msg.Text);
            
            Console.WriteLine(trade.k.c);
        }

    }
}