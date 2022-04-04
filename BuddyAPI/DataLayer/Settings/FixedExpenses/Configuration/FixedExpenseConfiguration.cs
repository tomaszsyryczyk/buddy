using BusinessLogic.Settings.FixedExpenses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Common.Datalayer;

namespace DataLayer.FixedExpenses.Configuration
{
    public class FixedExpenseConfiguration : IEntityTypeConfiguration<FixedExpense>
    {
        public void Configure(EntityTypeBuilder<FixedExpense> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Value).MoneyType();
        }
    }
}