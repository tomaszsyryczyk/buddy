using TS.Common;

namespace Buddy.Events.Wallet
{
    public class WalletEvent : Event
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public WalletEntryType Type { get; set; }
    }

    public enum WalletEntryType
    {
        Expenses = 0,
        Income = 1,
        Taxes = 2
    }
}
