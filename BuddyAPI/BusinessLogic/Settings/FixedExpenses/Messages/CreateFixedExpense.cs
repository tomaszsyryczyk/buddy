using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class CreateFixedExpense : INotification
    {
        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}
