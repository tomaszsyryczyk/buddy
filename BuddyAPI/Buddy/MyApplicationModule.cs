using Autofac;
using Buddy.Events.Stock;
using Buddy.Events.Wallet;
using TS.Common;

namespace Buddy
{
    public class MyApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterEventSourcing(typeof(MyApplicationModule).Assembly);
            builder.RegisterType<StockRepository>().As<IStockRepository>();
            builder.RegisterType<WalletRepository>().As<IWalletRepository>();
        }
    }
}
