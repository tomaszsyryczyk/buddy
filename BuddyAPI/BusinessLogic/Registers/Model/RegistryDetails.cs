using System;
using BusinessLogic.Registers.Entities;

namespace BusinessLogic.Registers.Model
{
    public class RegistryDetails
    {
        public int Id { get; set; }
        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }
    }
}
