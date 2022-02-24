using System.Threading.Tasks;
using BusinessLogic.Stocks.Models;

namespace BusinessLogic.Stocks
{
    public interface IStocksRepository
    {
        Task<CurrentStock[]> Current();
        Task<HistoryStock[]> History();
        void Add(CurrentStock stock);
    }
}
