using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Registers;
using BusinessLogic.Registers.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Registers
{
    internal class RegistersRepository : IRegistersRepository
    {
        private readonly BuddyDbContext _context;

        public RegistersRepository(BuddyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Registry entity)
        {
            await _context.Registry.AddAsync(entity);
        }

        public async Task<IEnumerable<Registry>> All()
        {
            var data = await _context
                .Registry
                .ToListAsync();

            return data;
        }

        public async Task Delete(int id)
        {
            var item = await Get(id);
            _context.Registry.Remove(item);
        }

        public async Task<Registry> Get(int id)
        {
            return await _context.Registry.FindAsync(id);
        }
    }
}
