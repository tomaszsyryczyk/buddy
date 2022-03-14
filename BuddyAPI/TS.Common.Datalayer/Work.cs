using Microsoft.EntityFrameworkCore;

namespace TS.Common.Datalayer
{
    public class Work : IWork

    {
        private readonly DbContext _context;

        public Work(DbContext context)
        {
            _context = context;
        }

        public IUnitOfWork Start()
        {
            return new UnitOfWork(_context);
        }
    }

    public class EventWork : IEventWork

    {
        private readonly DbContext _context;

        public EventWork(DbContext context)
        {
            _context = context;
        }

        public IUnitOfWork Start()
        {
            return new UnitOfWork(_context);
        }
    }
}
