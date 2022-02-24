using TS.Common;

namespace BusinessLogic.Stocks.Events
{
    public class StockEvent : Event
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public StockEventType Type { get; set; }
        public double Fee { get; set; }
    }

    public enum StockEventType
    {
        Buy = 0,
        Sell = 1
    }
}
