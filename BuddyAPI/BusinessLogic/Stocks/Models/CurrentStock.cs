using System;

namespace BusinessLogic.Stocks.Models
{
    public class CurrentStock
    {
        public CurrentStock(string name, int count, double price, DateTimeOffset date, double onNothing)
        {
            Name = name;
            Count = count;
            Price = price;
            Date = date;
            PriceForNothing = onNothing;
        }

        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public DateTimeOffset Date { get; set; }
        public double PriceForNothing { get; set; }

    }
}
