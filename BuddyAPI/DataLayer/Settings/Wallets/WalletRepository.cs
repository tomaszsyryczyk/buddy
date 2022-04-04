using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets;
using BusinessLogic.Settings.Wallets.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Settings.Wallets
{
    internal class WalletRepository : IWalletRepository
    {
        private readonly BuddyDbContext _context;

        public WalletRepository(BuddyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Wallet entity)
        {
            await _context.Wallets.AddAsync(entity);
        }

        public async Task<Wallet> Get(int id)
        {
            return await _context.Wallets.FindAsync(id);
        }

        public async Task<IEnumerable<Wallet>> All()
        {
            return await _context.Wallets.ToListAsync();
        }

    }
}
