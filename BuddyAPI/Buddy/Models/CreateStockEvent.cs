using System;

namespace Buddy.Models
{
    public class CreateStockEvent
    {
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public CreateStockEventType Type { get; set; }

        public double Fee { get; set; }
    }

    public enum CreateStockEventType
    {
        Buy = 0,
        Sell = 1
    }
}
