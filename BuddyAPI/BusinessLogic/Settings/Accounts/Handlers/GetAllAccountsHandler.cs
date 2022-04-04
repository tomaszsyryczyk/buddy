using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.Accounts.Messeges;
using BusinessLogic.Settings.Accounts.Model;
using MediatR;

namespace BusinessLogic.Settings.Accounts.Handlers
{
    public class GetAllAccountsHandler : IRequestHandler<GetAllAccounts, AccountList>
    {
        private readonly IAccountsRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAccountsHandler(IAccountsRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AccountList> Handle(GetAllAccounts request, CancellationToken cancellationToken)
        {
            var all = await _repository.All();

            var result = all.Where(x => x.IsDeleted == false).Select(_mapper.Map<AccountDetails>);

            return new AccountList()
            {
                Accounts = result
            };
        }
    }
}
