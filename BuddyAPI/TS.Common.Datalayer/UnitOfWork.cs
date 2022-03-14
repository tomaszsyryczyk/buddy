using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace TS.Common.Datalayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            _transaction = context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            _transaction?.Rollback();
            // why?
            GC.SuppressFinalize(this);
        }

        public async Task Done()
        {
            if(_transaction == null)
                throw new InvalidOperationException("Transaction already closed");

            await _context.SaveChangesAsync();
            await _transaction.CommitAsync();
            _transaction = null;
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
