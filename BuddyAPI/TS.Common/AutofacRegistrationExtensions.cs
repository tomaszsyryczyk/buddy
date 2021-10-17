using System.Reflection;
using Autofac;

namespace TS.Common
{
    public static class AutofacRegistrationExtensions
    {
        public static void RegisterEventSourcing(this ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IHandleEventPersist<>))
                .AsImplementedInterfaces();


            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IHandleEventProvide<>))
                .AsImplementedInterfaces();
        }
    }
}
