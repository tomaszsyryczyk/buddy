using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Settings.FixedExpenses.Messages;
using DataLayer.Settings.FixedExpenses.Model;
using MediatR;

namespace BusinessLogic.Settings.FixedExpenses.Handlers
{
    public class GetAllFixedExpenseHandler : IRequestHandler<GetAllFixedExpense, IEnumerable<FixedExpenseDetails>>
    {
        private readonly IFixedExpenseRepository _repository;
        private readonly IMapper _mapper;

        public GetAllFixedExpenseHandler(IFixedExpenseRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<FixedExpenseDetails>> Handle(GetAllFixedExpense request, CancellationToken cancellationToken)
        {
            var all = await _repository.All();

            var result = all.Select(_mapper.Map<FixedExpenseDetails>);

            return result;
        }
    }
}
