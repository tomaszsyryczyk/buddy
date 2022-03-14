using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Events.Wallet.Configuration
{
    public class DeleteSourceEventConfiguration : IEntityTypeConfiguration<DeleteSourceEvent>
    {
        public void Configure(EntityTypeBuilder<DeleteSourceEvent> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.Id);
            builder.Property(x => x.When);
        }
    }
}
