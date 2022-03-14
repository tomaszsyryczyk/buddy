using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.Events.Wallet.Configuration
{
    public class AddSourceEventConfiguration : IEntityTypeConfiguration<AddSourceEvent>
    {
        public void Configure(EntityTypeBuilder<AddSourceEvent> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.Name);
            builder.Property(x => x.Type).AsString();
            builder.Property(x => x.When);
        }
    }
}
