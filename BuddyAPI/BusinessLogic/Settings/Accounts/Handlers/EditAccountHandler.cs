using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Accounts.Handlers
{
    public class EditAccountHandler : INotificationHandler<EditAccount>
    {
        private readonly IWork _work;
        private readonly IAccountsRepository _repository;

        public EditAccountHandler(IWork work, IAccountsRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(EditAccount request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();
            var item = await _repository.Get(request.Id);
            item.Update(request.Name, request.IBAN);

            await unitOfWork.Done();
        }
    }
}
