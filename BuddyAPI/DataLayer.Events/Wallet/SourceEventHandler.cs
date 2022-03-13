using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using TS.Common;

namespace DataLayer.Events.Wallet
{
    internal class SourceEventHandler :
        IHandleEventPersist<AddSourceEvent>,
        IHandleEventPersist<EditSourceEvent>,
        IHandleEventPersist<DeleteSourceEvent>,
        IHandleEventProvide<AddSourceEvent>,
        IHandleEventProvide<EditSourceEvent>,
        IHandleEventProvide<DeleteSourceEvent>
    {
        private readonly EventDbContext _dbContext;

        public SourceEventHandler(EventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Persist(AddSourceEvent persistEvent)
        {
            await _dbContext.AddSourceEvent.AddAsync(persistEvent);
        }

        public Task<AddSourceEvent[]> All()
        {
            return _dbContext.AddSourceEvent.OrderBy(x => x.When).ToArrayAsync();
        }

        public async Task Persist(EditSourceEvent persistEvent)
        {
            await _dbContext.EditSourceEvent.AddAsync(persistEvent);
        }

        public async Task Persist(DeleteSourceEvent persistEvent)
        {
            await _dbContext.DeleteSourceEvent.AddAsync(persistEvent);
        }

        Task<EditSourceEvent[]> IHandleEventProvide<EditSourceEvent>.All()
        {
            return _dbContext.EditSourceEvent.OrderBy(x => x.When).ToArrayAsync();
        }

        Task<DeleteSourceEvent[]> IHandleEventProvide<DeleteSourceEvent>.All()
        {
            return _dbContext.DeleteSourceEvent.OrderBy(x => x.When).ToArrayAsync();
        }
    }
}