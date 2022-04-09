using System;
using BusinessLogic.Registers.Entities;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class CreateRegistry : INotification
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }
    }

   
}
