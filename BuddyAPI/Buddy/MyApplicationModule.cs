using Autofac;
using BusinessLogic.Stocks;
using DataLayer;
using TS.Common;

namespace Buddy
{
    public class MyApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterEventHandlers(typeof(MyApplicationModule).Assembly);
            builder.RegisterType<StocksRepository>().As<IStocksRepository>();
        }
    }
}
