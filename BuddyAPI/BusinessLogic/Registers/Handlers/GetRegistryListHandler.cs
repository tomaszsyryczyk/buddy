using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Registers.Messages;
using BusinessLogic.Registers.Model;
using MediatR;

namespace BusinessLogic.Registers.Handlers
{
    public class GetRegistryListHandler : IRequestHandler<GetRegistryList, RegistryList>
    {
        private readonly IRegistersRepository _repository;
        private readonly IMapper _mapper;

        public GetRegistryListHandler(IRegistersRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<RegistryList> Handle(GetRegistryList request, CancellationToken cancellationToken)
        {
            var all = await _repository.All(request.From, request.To);

            var result = all.Select(_mapper.Map<RegistryDetails>);

            return new RegistryList()
            {
                Registries = result
            };
        }
    }
}
