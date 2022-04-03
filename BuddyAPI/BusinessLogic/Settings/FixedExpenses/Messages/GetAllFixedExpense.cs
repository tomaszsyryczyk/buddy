using System.Collections.Generic;
using DataLayer.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class GetAllFixedExpense : IRequest<IEnumerable<FixedExpenseDetails>>
    {
    }
}
