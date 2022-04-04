using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets.Entities;

namespace BusinessLogic.Settings.Wallets
{
    public interface IWalletRepository
    {
        Task Add(Wallet entity);
        Task<Wallet> Get(int id);
        Task<IEnumerable<Wallet>> All();
    }
}
