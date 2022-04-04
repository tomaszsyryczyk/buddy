using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Wallets.Handlers
{
    public class DeleteWalletHandler : INotificationHandler<DeleteWallet>
    {
        private readonly IWalletRepository _repository;
        private readonly IWork _work;

        public DeleteWalletHandler(IWalletRepository repository, IWork work)
        {
            _work = work;
            _repository = repository;
        }

        public async Task Handle(DeleteWallet request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            var item = await _repository.Get(request.Id);
            item.Delete();

            await unitOfWork.Done();
        }
    }
}
