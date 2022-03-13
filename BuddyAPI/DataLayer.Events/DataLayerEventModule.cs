using Autofac;
using TS.Common;
using TS.Common.Datalayer;

namespace DataLayer.Events
{
    public class DataLayerEventModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(DataLayerEventModule).Assembly;
            base.Load(builder); 
            builder.RegisterByNameConvention(assembly, "EventHandler");
            builder.Register(context => new Work(context.Resolve<EventDbContext>())).As<IEventWork>()
                .InstancePerLifetimeScope();
        }
    }
}