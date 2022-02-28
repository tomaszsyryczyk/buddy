using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using BusinessLogic.Wallet.Model;

namespace BusinessLogic.Wallet
{
    public interface ISourceRepository
    {
        Task Add(AddSourceEventType toExecuteType, string toExecuteName);
        Task Edit(int toExecuteId, AddSourceEventType toExecuteType, string toExecuteName);
        Task Remove(int toExecuteId);
        Task<Source> Get(int id);
        Task<Source[]> GetAll();
    }
}
