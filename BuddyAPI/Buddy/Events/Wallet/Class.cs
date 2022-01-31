using System;

namespace Buddy.Events.Wallet
{
    public class WalletEntry : WalletEvent
    {
        public WalletEntry(string name, decimal value, WalletEntryType type, DateTimeOffset when)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
            this.When = when;
        }

        public decimal Balance { get; set; }

        public void SetPreviousEntry(WalletEntry last)
        {
            if (last != null)
            {
                switch (this.Type)
                {
                    case WalletEntryType.Expenses:
                    case WalletEntryType.Taxes:
                        this.Balance = last.Balance - this.Value;
                        break;
                    case WalletEntryType.Income:
                        this.Balance = last.Balance + this.Value;
                        break;
                }
            }
            else
            {
                this.Balance = this.Value;
            }
        }
    }
}
