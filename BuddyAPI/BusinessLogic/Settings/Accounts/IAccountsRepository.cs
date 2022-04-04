using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts.Entities;

namespace BusinessLogic.Settings.Accounts
{
    public interface IAccountsRepository
    {
        Task Add(Account account);
        Task<Account> Get(int requestId);
        Task<IEnumerable<Account>> All();
    }
}
