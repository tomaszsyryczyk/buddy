using System;

namespace BusinessLogic.Registers.Entities
{
    public class Registry : Entity
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset When { get; set; }

        public RegistryType Type { get; set; }

        public decimal Amount { get; set; }

        public void Update(string requestFrom, string requestTo, decimal requestAmount, DateTimeOffset requestWhen, RegistryType requestType )
        {
            this.From = requestFrom;
            this.To = requestTo;
            this.Amount = requestAmount;
            this.When = requestWhen;
            this.Type = requestType;
        }
    }
}
