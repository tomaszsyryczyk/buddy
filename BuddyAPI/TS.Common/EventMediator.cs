using System.Threading.Tasks;

namespace TS.Common
{
    public class EventMediator<TEvent> : IMediateEvents<TEvent>
    where TEvent : Event
    {
        private readonly IHandleEventPersist<TEvent> _eventPersister;
        private readonly IHandleEventProvide<TEvent> _eventProvider;

        public EventMediator(IHandleEventPersist<TEvent> eventPersister, IHandleEventProvide<TEvent> eventProvider)
        {
            _eventProvider = eventProvider;
            _eventPersister = eventPersister;
        }

        public async Task Persist(TEvent persistEvent)
        {
            await _eventPersister.Persist(persistEvent);
        }

        public async Task<TEvent[]> All()
        {
            return await _eventProvider.All();
        }
    }
}
