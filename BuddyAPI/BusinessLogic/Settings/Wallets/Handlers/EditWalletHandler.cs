using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets.Messeges;
using MediatR;
using TS.Common;

namespace BusinessLogic.Settings.Wallets.Handlers
{
    public class EditWalletHandler : INotificationHandler<EditWallet>
    {
        private readonly IWork _work;
        private readonly IWalletRepository _repository;

        public EditWalletHandler(IWork work, IWalletRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(EditWallet request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();
            var item = await _repository.Get(request.Id);
            item.Update(request.Name);

            await unitOfWork.Done();
        }
    }
}
