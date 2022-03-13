using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Wallet;
using BusinessLogic.Wallet.Events;
using BusinessLogic.Wallet.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Wallet
{
    internal class SourceRepository : ISourceRepository
    {
        private readonly BuddyDbContext _context;

        public SourceRepository(BuddyDbContext context)
        {
            _context = context;
        }

        public async Task Add(AddSourceType type, string name)
        {
            await _context.Source.AddAsync(new Source(name, Map(type)));
        }

        public async Task Edit(int id, AddSourceType newType, string newName)
        {
            var source = await _context.Source.FirstOrDefaultAsync(x => x.Id == id);
            if (source != null)
            {
                source.Name = newName;
                source.Type = Map(newType);
            }
        }

        public async Task Remove(int id)
        {
            var source = await _context.Source.FirstOrDefaultAsync(x => x.Id == id);
            if (source != null)
            {
                _context.Source.Remove(source);
            }
        }

        public async Task<Source> Get(int id)
        {
            var source = await _context.Source.FirstOrDefaultAsync(x => x.Id == id);
            if (source != null)
            {
                return source;
            }

            //todo:
            throw new ArgumentException("");
        }

        public async Task<Source[]> GetAll()
        {
            return await _context.Source.ToArrayAsync();
        }

        private SourceType Map(AddSourceType type)
        {
            var dict = new Dictionary<AddSourceType, SourceType>()
            {
                {AddSourceType.Wallet, SourceType.Wallet },
                { AddSourceType.Account, SourceType.Account}
            };

            return dict[type];
        }
    }
}
