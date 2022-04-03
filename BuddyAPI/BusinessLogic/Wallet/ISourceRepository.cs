using System.Threading.Tasks;
using BusinessLogic.Wallet.Model;

namespace BusinessLogic.Wallet
{
    public interface ISourceRepository
    {
        Task Remove(int toExecuteId);
        Task<Source> Get(int id);
        Task<Source[]> GetAll();
    }
}
