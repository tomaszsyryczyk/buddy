using System;
using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class DeleteFixedExpenseHandler : INotificationHandler<DeleteFixedExpense>
    {
        private readonly IFixedExpenseRepository _repository;
        private readonly IWork _work;

        public DeleteFixedExpenseHandler(IFixedExpenseRepository repository, IWork work)
        {
            _work = work;
            _repository = repository;
        }

        public async Task Handle(DeleteFixedExpense notification, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Delete(notification.Id);

            await unitOfWork.Done();
        }
    }
}
