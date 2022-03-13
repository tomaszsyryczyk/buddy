using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TS.Common.Datalayer
{
    public static class DbContextInitExtensions
    {
        public static DbContextOptionsBuilder UseServerWithSchema(this DbContextOptionsBuilder optionsBuilder, string connString, string schemaName, Action<SqlServerDbContextOptionsBuilder> optionsAction = null)
        {
            return optionsBuilder.UseSqlServer(connString, builder =>
            {
                optionsAction?.Invoke(builder);
                builder.MigrationsHistoryTable("__EFMigrationsHistory", schemaName);
            });
        }
    }
}
