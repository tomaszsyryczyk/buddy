using Autofac;
using TS.Common;

namespace BusinessLogic
{
    public class BusinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(BusinessLogicModule).Assembly;
            base.Load(builder);

            builder.RegisterByNameConvention(assembly, "Handler");
        }
    }
}
