using System;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class CreateRegistry : INotification
    {
        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }

        public decimal Amount { get; set; }
    }
}
