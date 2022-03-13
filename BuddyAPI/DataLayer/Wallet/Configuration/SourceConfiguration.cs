using System;
using BusinessLogic.Wallet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.Wallet.Configuration
{
    public class SourceConfiguration : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Type).AsString();
        }
    }
}
