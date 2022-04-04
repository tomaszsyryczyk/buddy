using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts;
using BusinessLogic.Settings.Accounts.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Settings.Accounts
{
    internal class AccountsRepository : IAccountsRepository
    {
        private readonly BuddyDbContext _context;

        public AccountsRepository(BuddyDbContext context)
        {
            _context = context;
        }


        public async Task Add(Account account)
        {
            await _context.Accounts.AddAsync(account);
        }

        public async Task<Account> Get(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<IEnumerable<Account>> All()
        {
            return await _context.Accounts.ToListAsync();
        }
    }
}
