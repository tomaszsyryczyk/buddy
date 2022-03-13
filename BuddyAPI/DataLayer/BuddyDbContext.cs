﻿using BusinessLogic.Wallet.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class BuddyDbContext : DbContext
    {
        public BuddyDbContext(DbContextOptions<BuddyDbContext> options)
            : base(options)
        {

        }
        public DbSet<Source> Source { get; set; }
    }
}
