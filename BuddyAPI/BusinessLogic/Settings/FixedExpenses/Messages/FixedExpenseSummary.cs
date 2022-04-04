using BusinessLogic.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Messages
{
    public class FixedExpenseSummary : IRequest<FixedExpenseSummaryDetails>
    {
    }
}
