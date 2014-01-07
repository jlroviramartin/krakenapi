using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KrakenClient;
using Jayrock.Json.Conversion;
using System.Collections;
using System.Globalization;
using Jayrock.Json;
using System.Threading;

namespace KrakenClientConsole
{
    public class Program
    {

        public static  KrakenClient.KrakenClient client = new KrakenClient.KrakenClient();
      
        public static void Main(string[] args)
        {
            KrakenClient.KrakenClient client = new KrakenClient.KrakenClient();

            Console.WriteLine("calling kraken api...\n\n");

            //var time = client.GetServerTime();
            //Console.WriteLine("time: " + time.ToString() + "\n\n");

            //var assets = client.GetActiveAssets();
            //Console.WriteLine("assets: " + assets.ToString() + "\n\n");

            //var assetPairs = client.GetAssetPairs(new List<string> { "XXBTZEUR" });
            //Console.WriteLine("asset pairs: " + assetPairs.ToString() + "\n\n");

            //var ticker = client.GetTicker(new List<string> { "XXBTZEUR" });
            //Console.WriteLine("ticker: " + ticker.ToString() + "\n\n");

            //var depth = client.GetOrderBook("XXBTZUSD", 1);
            //Console.WriteLine("depth: " + depth.ToString() + "\n\n");

            //var trades = client.GetRecentTrades("XXBTZEUR", 137589964200000000);
            //Console.WriteLine("trades: " + trades.ToString() + "\n\n");

            //var spreads = client.GetRecentSpreadData("XXBTZEUR", 137589964200000000);
            //Console.WriteLine("spreads: " + spreads.ToString() + "\n\n");

            //var balance = client.GetBalance();
            //Console.WriteLine("balance: " + balance.ToString() + "\n\n");

            //var tradeBalance = client.GetTradeBalance("currency", string.Empty);
            //Console.WriteLine("trade balance: " + tradeBalance.ToString() + "\n\n");

            //var openOrders = client.GetOpenOrders();
            //Console.WriteLine("open orders: " + openOrders.ToString() + "\n\n");

            //var closedOrders = client.GetClosedOrders();
            //Console.WriteLine("closed orders: " + closedOrders.ToString() + "\n\n");

            //var queryOrders = client.QueryOrders(string.Empty);
            //Console.WriteLine("query orders: " + queryOrders.ToString() + "\n\n");

            var tradesHistory = client.GetTradesHistory(string.Empty);
            Console.WriteLine("trades history: " + tradesHistory.ToString() + "\n\n");

            //var queryTrades = client.QueryTrades();
            //Console.WriteLine("query trades: " + queryTrades.ToString() + "\n\n");

            //var openPositions = client.GetOpenPositions();
            //Console.WriteLine("open positions: " + openPositions.ToString() + "\n\n");

            //var ledgers = client.GetLedgers();
            //Console.WriteLine("ledgers: " + ledgers.ToString() + "\n\n");

            //var queryLedgers = client.QueryLedgers();
            //Console.WriteLine("query ledgers: " + queryLedgers.ToString() + "\n\n");

            //var tradeVolume = client.GetTradeVolume();
            //Console.WriteLine("trade volume: " + tradeVolume.ToString() + "\n\n");

            //var closeDictionary = new Dictionary<string,string>();
            //closeDictionary.Add("ordertype","stop-loss-profit");
            //closeDictionary.Add("price","#5%");
            //closeDictionary.Add("price2","#10");
            
            //var addOrderRes = client.AddOrder("XXBTZEUR",
            //    "buy",
            //    "limit",
            //    (decimal)2.12345678,
            //    (decimal)101.9901,
            //    null,
            //    @"1:1",
            //    "",
            //    "",
            //    "",
            //    "",
            //    "",
            //    true,                
            //    closeDictionary);

            //Console.WriteLine("add order result: " + addOrderRes.ToString());

            //var cancelOrder = client.CancelOrder("");
            //Console.WriteLine("cancel order : " + cancelOrder.ToString());
                

            Console.ReadLine();


        }


    }
}
