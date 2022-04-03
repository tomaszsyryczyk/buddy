using System.Reflection;
using Autofac;

namespace TS.Common
{
    public static class AutofacRegistrationExtensions
    {
        public static void RegisterByNameConvention(this ContainerBuilder builder, Assembly assembly, string endsWith)
        {
            builder.RegisterAssemblyTypes(assembly)
                          .Where(x => x.Name.EndsWith(endsWith))
                          .AsImplementedInterfaces();
        }

        public static void RegisterByNameConventionWithAutowired(this ContainerBuilder builder, Assembly assembly, string endsWith )
        {
            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.Name.EndsWith(endsWith))
                .AsImplementedInterfaces()
                .PropertiesAutowired();
        }
    }
}
