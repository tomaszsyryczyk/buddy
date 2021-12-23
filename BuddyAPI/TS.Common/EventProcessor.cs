using System.Collections.Generic;
using System.Threading.Tasks;

namespace TS.Common
{
    public class EventProcessor<TEvent> : IProcessEvents<TEvent>
        where TEvent : Event
    {
        private readonly IHandleEventPersist<TEvent> _eventPersister;
        private readonly IHandleEventProvide<TEvent> _eventProvider;
        private readonly ICollection<IHandleEventExecution<TEvent>> _eventExecutioners;

        public EventProcessor(IHandleEventPersist<TEvent> eventPersister,
            IHandleEventProvide<TEvent> eventProvider,
            ICollection<IHandleEventExecution<TEvent>> eventExecutioners)
        {
            _eventExecutioners = eventExecutioners;
            _eventProvider = eventProvider;
            _eventPersister = eventPersister;
        }

        public async Task Process(TEvent persistEvent)
        {
            await _eventPersister.Persist(persistEvent);
            Parallel.ForEach(_eventExecutioners, (x) => x.Execute(persistEvent));
        }

        public async Task<TEvent[]> All()
        {
            return await _eventProvider.All();
        }
    }
}
