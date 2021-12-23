using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TS.Common;

namespace Buddy.Events.Wallet
{
    public class WalletEventHandler : IHandleEventPersist<WalletEvent>, IHandleEventProvide<WalletEvent>
    {
        private static List<WalletEvent> _events;

        public WalletEventHandler()
        {
            if (_events == null)
                _events = new List<WalletEvent>();
        }

        public async Task Persist(WalletEvent persistEvent)
        {
            _events.Add(persistEvent);
        }

        public async Task<WalletEvent[]> All()
        {
            return _events.OrderBy(x => x.When).ToArray();
        }
    }
}
