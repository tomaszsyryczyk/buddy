using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.Accounts.Messeges;
using BusinessLogic.Settings.Accounts.Model;
using MediatR;

namespace BusinessLogic.Settings.Accounts.Handlers
{
    public class GetAccountHandler : IRequestHandler<GetAccount,AccountDetails>
    {
        private readonly IAccountsRepository _repository;
        private readonly IMapper _mapper;

        public GetAccountHandler(IAccountsRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AccountDetails> Handle(GetAccount request, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(request.Id);

            var result = _mapper.Map<AccountDetails>(item);

            return result;
        }
    }
}
