using System;
using Buddy.Events.Wallet;

namespace Buddy.Models
{
    public class WalletGetResponse
    {
        public decimal Balance { get; set; }

        public WalletEntry[] Entries { get; set; }
    }
}
