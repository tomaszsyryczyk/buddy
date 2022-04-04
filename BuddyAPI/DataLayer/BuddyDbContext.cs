using BusinessLogic.Settings.Accounts.Entities;
using BusinessLogic.Settings.FixedExpenses.Entities;
using BusinessLogic.Settings.Wallets.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class BuddyDbContext : DbContext
    {
        public BuddyDbContext(DbContextOptions<BuddyDbContext> options)
            : base(options)
        {

        }
        public DbSet<FixedExpense> FixedExpense { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BuddyDbContext).Assembly);
        }
    }
}
