using System;

namespace Buddy.Models
{
    public class WalletEventsGetRequest
    {
        public DateTimeOffset? From { get; set; }

        public DateTimeOffset? To { get; set; }
    }
}
