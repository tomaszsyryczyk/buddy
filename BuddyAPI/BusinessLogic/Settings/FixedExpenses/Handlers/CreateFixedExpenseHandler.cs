using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Entities;
using BusinessLogic.Settings.FixedExpenses.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class CreateFixedExpenseHandler : INotificationHandler<CreateFixedExpense>
    {
        private readonly IWork _work;
        private readonly IFixedExpenseRepository _repository;


        public CreateFixedExpenseHandler(IWork work, IFixedExpenseRepository repository)
        {
            _repository = repository;
            _work = work;
        }
        public async Task Handle(CreateFixedExpense request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Add(new FixedExpense(request.Name,request.Value));

            await unitOfWork.Done();
        }
    }
}
