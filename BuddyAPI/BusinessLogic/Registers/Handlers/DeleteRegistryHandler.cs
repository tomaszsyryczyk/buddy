using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Registers.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Registers.Handlers
{
    public class DeleteRegistryHandler : INotificationHandler<DeleteRegistry>
    {
        private readonly IRegistersRepository _repository;
        private readonly IWork _work;

        public DeleteRegistryHandler(IRegistersRepository repository, IWork work)
        {
            _work = work;
            _repository = repository;
        }

        public async Task Handle(DeleteRegistry request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();

            await _repository.Delete(request.Id);

            await unitOfWork.Done();
        }
    }
}
