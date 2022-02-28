using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using TS.Common;

namespace BusinessLogic.Wallet
{
    internal class SourceEventExecutor : 
        IHandleEventExecution<AddSourceEvent>,
        IHandleEventExecution<EditSourceEvent>,
        IHandleEventExecution<DeleteSourceEvent>
    {
        private readonly ISourceRepository _repository;

        public SourceEventExecutor(ISourceRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(AddSourceEvent toExecute)
        {
            await _repository.Add(toExecute.Type, toExecute.Name);
        }

        public async Task Execute(EditSourceEvent toExecute)
        {
            await _repository.Edit(toExecute.Id,toExecute.Type, toExecute.Name);
        }

        public async Task Execute(DeleteSourceEvent toExecute)
        {
            await _repository.Remove(toExecute.Id);
        }
    }
}
