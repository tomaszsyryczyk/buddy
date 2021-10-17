using System;
using System.Collections.Generic;

namespace Buddy.Models
{
    public class HistoryStock
    {
        public IList<BuyHistoryStock> BuyStocks { get; set; }
        public IList<SellHistoryStock> SellStocks { get; set; }
    }

    public class BuyHistoryStock
    {
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }

    public class SellHistoryStock
    {
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double ValueAtBuyAvg { get; set; }
        public double ValueAtSell { get; set; }
        public double Income { get; set; }
        public double Delta { get; set; }
    }
}
