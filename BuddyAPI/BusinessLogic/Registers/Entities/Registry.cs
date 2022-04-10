using System;

namespace BusinessLogic.Registers.Entities
{
    public class Registry : Entity
    {
        public DateTimeOffset When { get; set; }
        public RegistryType Type { get; set; }
        public decimal Amount { get; set; }
        public string Name { get; set; }

        public void Update(decimal requestAmount, DateTimeOffset requestWhen, RegistryType requestType, string requestName )
        {
            this.Amount = requestAmount;
            this.When = requestWhen;
            this.Type = requestType;
            this.Name = requestName;
        }
    }
}
