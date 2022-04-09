using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Registers.Entities;
using BusinessLogic.Registers.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Registers.Handlers
{
    public class CreateRegistryHandler : INotificationHandler<CreateRegistry>
    {
        private readonly IWork _work;
        private readonly IRegistersRepository _repository;


        public CreateRegistryHandler(IWork work, IRegistersRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(CreateRegistry request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Add(new Registry()
            {
                Amount = request.Amount,
                From = request.From,
                To = request.To,
                Type = request.Type,
                When = request.When
            });

            await unitOfWork.Done();
        }
    }
}
