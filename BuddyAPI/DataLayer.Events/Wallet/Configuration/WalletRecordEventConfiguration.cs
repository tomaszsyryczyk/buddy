using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.Events.Wallet.Configuration
{
    public class WalletRecordEventConfiguration : IEntityTypeConfiguration<WalletRecordEvent>
    {
        public void Configure(EntityTypeBuilder<WalletRecordEvent> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.SourceId);
            builder.Property(x => x.Source);
            builder.Property(x => x.DestinationId);
            builder.Property(x => x.Destination);
            builder.Property(x => x.Amount).MoneyType();
            builder.Property(x => x.When);
        }
    }
}
