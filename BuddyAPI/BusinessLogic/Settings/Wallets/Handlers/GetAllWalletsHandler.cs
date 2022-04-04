using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.Accounts;
using BusinessLogic.Settings.Wallets.Messeges;
using BusinessLogic.Settings.Wallets.Model;
using MediatR;

namespace BusinessLogic.Settings.Wallets.Handlers
{
    public class GetAllWalletsHandler : IRequestHandler<GetAllWallets, WalletList>
    {
        private readonly IAccountsRepository _repository;
        private readonly IMapper _mapper;

        public GetAllWalletsHandler(IAccountsRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<WalletList> Handle(GetAllWallets request, CancellationToken cancellationToken)
        {
            var all = await _repository.All();

            var result = all.Where(x => x.IsDeleted == false).Select(_mapper.Map<WalletDetails>);

            return new WalletList()
            {
                Wallets = result
            };
        }
    }
}
