using Autofac;
using BusinessLogic;
using TS.Common;

namespace Buddy
{
    public class MyApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<UserProvider>().As<IUserProvider>().InstancePerLifetimeScope();

            builder.RegisterByNameConventionWithAutowired(typeof(MyApplicationModule).Assembly, "Controller");
        }
    }
}
