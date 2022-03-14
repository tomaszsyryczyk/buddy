using System.Reflection;
using BusinessLogic.Wallet.Events;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Events
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options)
        : base (options)
        {
            
        }

        public DbSet<AddSourceEvent> AddSourceEvent { get; set; }
        public DbSet<EditSourceEvent> EditSourceEvent { get; set; }
        public DbSet<DeleteSourceEvent> DeleteSourceEvent { get; set; }
        public DbSet<WalletRecordEvent> WalletRecordEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventDbContext).Assembly);
        }
    }
}
