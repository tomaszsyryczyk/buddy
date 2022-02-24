using Autofac;
using TS.Common;

namespace DataLayer
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(DataLayerModule).Assembly;
            base.Load(builder);
            builder.RegisterRepositoriesByNameConvention(assembly);
        }
    }
}
