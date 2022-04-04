using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets.Entities;
using BusinessLogic.Settings.Wallets.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Wallets.Handlers
{
    public class CreateWalletHandler : INotificationHandler<CreateWallet>
    {
        private readonly IWork _work;
        private readonly IWalletRepository _repository;


        public CreateWalletHandler(IWork work, IWalletRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(CreateWallet request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Add(new Wallet(request.Name));

            await unitOfWork.Done();
        }
    }
}
