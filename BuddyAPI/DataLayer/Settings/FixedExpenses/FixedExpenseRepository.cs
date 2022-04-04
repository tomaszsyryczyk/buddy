using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses;
using BusinessLogic.Settings.FixedExpenses.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.FixedExpenses
{
    internal class FixedExpenseRepository : IFixedExpenseRepository
    {
        private readonly BuddyDbContext _context;

        public FixedExpenseRepository(BuddyDbContext context)
        {
            _context = context;
        }

        public async Task Add(FixedExpense fixedExpense)
        {
            await _context.FixedExpense.AddAsync(fixedExpense);
        }

        public async Task<IEnumerable<FixedExpense>> All()
        {
            var data = await _context
                .FixedExpense
                .ToListAsync();

            return data;
        }

        public async Task Delete(int id)
        {
            var item = await Get(id);
            _context.FixedExpense.Remove(item);
        }

        public async Task<FixedExpense> Get(int id)
        {
            return await _context.FixedExpense.FindAsync(id);
        }
    }
}
