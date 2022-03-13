using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using TS.Common;

namespace DataLayer.Events
{
    internal class SourceEventHandler :
        IHandleEventPersist<AddSourceEvent>,
        IHandleEventPersist<EditSourceEvent>,
        IHandleEventPersist<DeleteSourceEvent>,
        IHandleEventProvide<AddSourceEvent>,
        IHandleEventProvide<EditSourceEvent>,
        IHandleEventProvide<DeleteSourceEvent>
    {

        private static readonly List<AddSourceEvent> AddEvents = new List<AddSourceEvent>();
        private static readonly List<EditSourceEvent> EditEvents = new List<EditSourceEvent>();
        private static readonly List<DeleteSourceEvent> DeleteEvents = new List<DeleteSourceEvent>();

        public async Task Persist(AddSourceEvent persistEvent)
        {
            AddEvents.Add(persistEvent);
        }

        public async Task<AddSourceEvent[]> All()
        {
            return AddEvents.OrderBy(x => x.When).ToArray();
        }

        public async Task Persist(EditSourceEvent persistEvent)
        {
            EditEvents.Add(persistEvent);
        }

        public async Task Persist(DeleteSourceEvent persistEvent)
        {
            DeleteEvents.Add(persistEvent);
        }

        async Task<EditSourceEvent[]> IHandleEventProvide<EditSourceEvent>.All()
        {
            return EditEvents.OrderBy(x => x.When).ToArray();
        }

        async Task<DeleteSourceEvent[]> IHandleEventProvide<DeleteSourceEvent>.All()
        {
            return DeleteEvents.OrderBy(x => x.When).ToArray();
        }
    }
}
