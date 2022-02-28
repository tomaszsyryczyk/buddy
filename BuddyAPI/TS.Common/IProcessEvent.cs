using System.Threading.Tasks;
using Autofac;

namespace TS.Common
{
    public interface IProcessEvent
    {
        Task Process<TEvent>(TEvent eventToProcess)
            where TEvent : Event;
    }

    public class EventProcessor : IProcessEvent
    {
        private readonly IComponentContext _container;

        public EventProcessor(IComponentContext container)
        {
            _container = container;
        }

        public async Task Process<TEvent>(TEvent eventToProcess) where TEvent : Event
        {
            var mediator = _container.Resolve<IMediateEvents<TEvent>>();

            await mediator.Validate(eventToProcess);
            await mediator.Persist(eventToProcess);
            await mediator.Execute(eventToProcess);
        }
    }
}
