using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using TS.Common;

namespace DataLayer.Events
{
    internal class WalletRecordEventHandler : IHandleEventPersist<WalletRecordEvent>, IHandleEventProvide<WalletRecordEvent>
    {
        private static readonly List<WalletRecordEvent> Events = new List<WalletRecordEvent>();

        public async Task Persist(WalletRecordEvent persistEvent)
        {
            Events.Add(persistEvent);
        }

        public async Task<WalletRecordEvent[]> All()
        {
            return Events.OrderBy(x => x.When).ToArray();
        }
    }
}
