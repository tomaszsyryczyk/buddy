using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.FixedExpenses.Messages;
using DataLayer.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class GetFixedExpenseHandler : IRequestHandler<GetFixedExpense, FixedExpenseDetails>
    {
        private readonly IFixedExpenseRepository _repository;
        private readonly IMapper _mapper;

        public GetFixedExpenseHandler(IFixedExpenseRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<FixedExpenseDetails> Handle(GetFixedExpense request, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(request.Id);

            var result = _mapper.Map<FixedExpenseDetails>(item);

            return result;
        }
    }
}
