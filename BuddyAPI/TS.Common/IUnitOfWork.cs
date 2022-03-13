using System;
using System.Threading.Tasks;

namespace TS.Common
{
    public interface IUnitOfWork : IDisposable
    {
        Task Done();

        Task Save();
    }
}
