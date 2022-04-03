using DataLayer.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class GetFixedExpense : IRequest<FixedExpenseDetails>
    {
        public int Id { get; set; }

        public GetFixedExpense(int id)
        {
            Id = id;
        }
    }
}
