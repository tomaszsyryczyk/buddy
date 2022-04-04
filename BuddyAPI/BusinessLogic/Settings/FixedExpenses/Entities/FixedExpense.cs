namespace BusinessLogic.Settings.FixedExpenses.Entities
{
    public class FixedExpense : Entity
    {
        public FixedExpense(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public decimal Value { get; set; }

        public void Update(string newName, decimal newValue)
        {
            this.Name = newName;
            this.Value = newValue;
        }
    }
}
