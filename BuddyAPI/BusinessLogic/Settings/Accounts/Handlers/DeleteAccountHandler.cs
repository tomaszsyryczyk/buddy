using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Accounts.Handlers
{
    public class DeleteAccountHandler : INotificationHandler<DeleteAccount>
    {
        private readonly IAccountsRepository _repository;
        private readonly IWork _work;

        public DeleteAccountHandler(IAccountsRepository repository, IWork work)
        {
            _work = work;
            _repository = repository;
        }

        public async Task Handle(DeleteAccount request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            var item = await _repository.Get(request.Id);
            item.Delete();

            await unitOfWork.Done();
        }
    }
}
