using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Registers.Messages;
using BusinessLogic.Registers.Model;
using MediatR;

namespace BusinessLogic.Registers.Handlers
{
    public class GetRegistryHandler : IRequestHandler<GetRegistry, RegistryDetails>
    {
        private readonly IRegistersRepository _repository;
        private readonly IMapper _mapper;

        public GetRegistryHandler(IRegistersRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<RegistryDetails> Handle(GetRegistry request, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(request.Id);

            var result = _mapper.Map<RegistryDetails>(item);

            return result;
        }
    }
}
