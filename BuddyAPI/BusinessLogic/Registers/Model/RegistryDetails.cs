using System;
using BusinessLogic.Registers.Entities;

namespace BusinessLogic.Registers.Model
{
    public class RegistryDetails
    {
        public int Id { get; set; }

        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }
        public string Name { get; set; }

    }
}
