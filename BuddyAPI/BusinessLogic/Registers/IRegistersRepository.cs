using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Registers.Entities;

namespace BusinessLogic.Registers
{
    public interface IRegistersRepository
    {
        Task Add(Registry entity);
        Task<IEnumerable<Registry>> All();
        Task Delete(int id);
        Task<Registry> Get(int id);
    }
}
