using System;

namespace BusinessLogic.Registers.Entities
{
    public class Registry : Entity
    {
        public Registry(DateTimeOffset from, DateTimeOffset to, decimal amount)
        {
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }

        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }

        public decimal Amount { get; set; }


        public void Update(DateTimeOffset requestFrom, DateTimeOffset requestTo, decimal requestAmount)
        {
            this.From = requestFrom;
            this.To = requestTo;
            this.Amount = requestAmount;
        }
    }
}
