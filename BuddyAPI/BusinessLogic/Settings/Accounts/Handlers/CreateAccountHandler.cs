using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts.Entities;
using BusinessLogic.Settings.Accounts.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Accounts.Handlers
{
    public class CreateAccountHandler : INotificationHandler<CreateAccount>
    {
        private readonly IWork _work;
        private readonly IAccountsRepository _repository;


        public CreateAccountHandler(IWork work, IAccountsRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(CreateAccount request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Add(new Account(request.Name, request.IBAN));

            await unitOfWork.Done();
        }
    }
}
