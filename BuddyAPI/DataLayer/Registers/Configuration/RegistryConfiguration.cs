using BusinessLogic.Registers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.Registers.Configuration
{
    public class RegistryConfiguration : IEntityTypeConfiguration<Registry>
    {
        public void Configure(EntityTypeBuilder<Registry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.From);
            builder.Property(x => x.To);
            builder.Property(x => x.Type).EnumAsString();
            builder.Property(x => x.When).DatetimeOffsetType();
            builder.Property(x => x.Amount).MoneyType();
        }
    }
}