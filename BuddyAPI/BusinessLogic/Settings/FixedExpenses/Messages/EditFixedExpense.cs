using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class EditFixedExpense : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}
