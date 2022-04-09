﻿using System;
using BusinessLogic.Registers.Entities;
using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class EditRegistry : INotification
    {
        public int Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }
    }
}
