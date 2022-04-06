using System;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class EditRegistry : INotification
    {
        public int Id { get; set; }

        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }

        public decimal Amount { get; set; }
    }
}
