using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.Wallets.Messeges;
using BusinessLogic.Settings.Wallets.Model;
using MediatR;

namespace BusinessLogic.Settings.Wallets.Handlers
{
    public class GetWalletHandler : IRequestHandler<GetWallet, WalletDetails>
    {
        private readonly IWalletRepository _repository;
        private readonly IMapper _mapper;

        public GetWalletHandler(IWalletRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<WalletDetails> Handle(GetWallet request, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(request.Id);

            var result = _mapper.Map<WalletDetails>(item);

            return result;
        }
    }
}
