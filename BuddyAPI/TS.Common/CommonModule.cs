using System.Threading.Tasks;
using Autofac;

namespace TS.Common
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterGeneric(typeof(EventMediator<>)).As(typeof(IMediateEvents<>));
            builder.RegisterGeneric(typeof(HandleEventValidation<>)).As(typeof(IHandleEventValidation<>));
            builder.RegisterType<EventProcessor>().As<IProcessEvent>();
        }
    }

    internal class HandleEventValidation<TEvent> : IHandleEventValidation<TEvent> where TEvent : Event
    {
        public async Task Validate(TEvent toExecute)
        {
            
        }
    }
}
