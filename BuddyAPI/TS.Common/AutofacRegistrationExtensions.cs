using System.Reflection;
using Autofac;

namespace TS.Common
{
    public static class AutofacRegistrationExtensions
    {
        public static void RegisterEventHandlers(this ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IHandleEventPersist<>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IHandleEventProvide<>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IHandleEventExecution<>))
                .AsImplementedInterfaces();
        }

        public static void RegisterRepositoriesByNameConvention(this ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                          .Where(x => x.Name.EndsWith("Repository"))
                          .AsImplementedInterfaces();
        }
    }
}
