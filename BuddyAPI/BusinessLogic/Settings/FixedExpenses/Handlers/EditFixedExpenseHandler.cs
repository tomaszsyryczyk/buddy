using System;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class EditFixedExpenseHandler : INotificationHandler<EditFixedExpense>
    {
        private readonly IWork _work;
        private readonly IFixedExpenseRepository _repository;

        public EditFixedExpenseHandler(IWork work, IFixedExpenseRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(EditFixedExpense request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();
            var item = await _repository.Get(request.Id);
            item.Update(request.Name, request.Value);

            await unitOfWork.Done();
        }
    }
}
