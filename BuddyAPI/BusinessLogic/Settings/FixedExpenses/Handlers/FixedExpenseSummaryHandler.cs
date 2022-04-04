using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Messages;
using BusinessLogic.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class FixedExpenseSummaryHandler : IRequestHandler<FixedExpenseSummary, FixedExpenseSummaryDetails>
    {
        private readonly IFixedExpenseRepository _repository;

        public FixedExpenseSummaryHandler(IFixedExpenseRepository repository)
        {
            _repository = repository;
        }

        public async Task<FixedExpenseSummaryDetails> Handle(FixedExpenseSummary request, CancellationToken cancellationToken)
        {
            var allItems = await _repository.All();
            var result = new FixedExpenseSummaryDetails()
            {
                TotalValuePerMonth = allItems.Sum(x => x.Value),
            };

            return result;
        }
    }
}
