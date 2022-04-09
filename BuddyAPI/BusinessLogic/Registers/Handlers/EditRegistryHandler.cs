using System.Threading;
using System.Threading.Tasks;
using BusinessLogic.Registers.Messages;
using MediatR;
using TS.Common;

namespace BusinessLogic.Registers.Handlers
{
    internal class EditRegistryHandler : INotificationHandler<EditRegistry>
    {
        private readonly IWork _work;
        private readonly IRegistersRepository _repository;

        public EditRegistryHandler(IWork work, IRegistersRepository repository)
        {
            _repository = repository;
            _work = work;
        }

        public async Task Handle(EditRegistry request, CancellationToken cancellationToken)
        {
            var unitOfWork = _work.Start();
            var item = await _repository.Get(request.Id);
            item.Update(request.From, request.To, request.Amount, request.When, request.Type);

            await unitOfWork.Done();
        }
    }
}
