using Autofac;
using Buddy.Services;
using TS.Common;

namespace Buddy
{
    public class MyApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterEventSourcing(typeof(MyApplicationModule).Assembly);
            builder.RegisterType<StocksRepository>().As<IStocksRepository>();
        }
    }
}
