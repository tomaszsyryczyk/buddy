using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.Events.Wallet.Configuration
{
    public class EditSourceEventConfiguration : IEntityTypeConfiguration<EditSourceEvent>
    {
        public void Configure(EntityTypeBuilder<EditSourceEvent> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Type).AsString();
            builder.Property(x => x.When);
        }
    }
}
