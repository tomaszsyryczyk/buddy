using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class DeleteFixedExpense : INotification
    {
        public int Id { get; set; }
    }
}
