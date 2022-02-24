using TS.Common;

namespace BusinessLogic.Wallet.Events
{
    public class WalletRecordEvent : Event
    {
        public int? SourceId { get; set; }
        public string Source { get; set; }

        public int? DestinationId { get; set; }
        public string Destination { get; set; }

        public decimal Amount { get; set; }


    }
}
