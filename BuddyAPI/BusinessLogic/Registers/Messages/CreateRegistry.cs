using System;
using BusinessLogic.Registers.Entities;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class CreateRegistry : INotification
    {
        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }

        public string Name { get; set; }
    }

   
}
