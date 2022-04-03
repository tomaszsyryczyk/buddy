using Autofac;
using TS.Common;

namespace Buddy
{
    public class MyApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterByNameConventionWithAutowired(typeof(MyApplicationModule).Assembly, "Controller");
        }
    }
}
