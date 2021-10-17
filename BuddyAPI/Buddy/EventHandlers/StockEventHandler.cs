using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buddy.Events;
using TS.Common;

namespace Buddy.EventHandlers
{
    public class StockEventHandler : IHandleEventPersist<StockEvent>, IHandleEventProvide<StockEvent>
    {
        private static List<StockEvent> _events;

        public StockEventHandler()
        {
            if(_events == null)
                _events = new List<StockEvent>();
        }

        public async Task Persist(StockEvent persistEvent)
        {
            _events.Add(persistEvent);
        }

        public async Task<StockEvent[]> All()
        {
            return _events.OrderBy(x => x.When).ToArray();
        }
    }
}
