using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using TS.Common;

namespace DataLayer.Events.Wallet
{
    internal class WalletRecordEventHandler : IHandleEventPersist<WalletRecordEvent>, IHandleEventProvide<WalletRecordEvent>
    {
        private readonly EventDbContext _dbContext;
        public WalletRecordEventHandler(EventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Persist(WalletRecordEvent persistEvent)
        {
            await _dbContext.WalletRecordEvent.AddAsync(persistEvent);
        }

        public Task<WalletRecordEvent[]> All()
        {
            return _dbContext.WalletRecordEvent.OrderBy(x => x.When).ToArrayAsync();
        }
    }
}
