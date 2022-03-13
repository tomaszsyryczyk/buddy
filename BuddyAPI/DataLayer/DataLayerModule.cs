﻿using Autofac;
using TS.Common;
using TS.Common.Datalayer;

namespace DataLayer
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(DataLayerModule).Assembly;
            base.Load(builder);
            builder.RegisterRepositoriesByNameConvention(assembly);

            builder.Register(context => new Work(context.Resolve<BuddyDbContext>())).As<IWork>()
                .InstancePerLifetimeScope();
        }
    }
}
