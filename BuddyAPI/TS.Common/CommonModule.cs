using Autofac;

namespace TS.Common
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterGeneric(typeof(EventProcessor<>)).As(typeof(IProcessEvents<>));
        }
    }
}
