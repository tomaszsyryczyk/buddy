using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buddy.Models;

namespace Buddy.Events.Stock
{
    public interface IStockRepository
    {
        Task<CurrentStock[]> Current();
        Task<HistoryStock[]> History();
        void Add(CurrentStock stock);
    }

    public class StockRepository : IStockRepository
    {
        private static List<CurrentStock> _currentStocks;
        private static List<HistoryStock> _historyStocks;

        public StockRepository()
        {
            if(_currentStocks == null)
                _currentStocks = new List<CurrentStock>();

            if (_historyStocks == null)
                _historyStocks = new List<HistoryStock>();
        }

        public async Task<CurrentStock[]> Current()
        {
            return _currentStocks.OrderBy(x => x.Date).ToArray();
        }

        public async Task<HistoryStock[]> History()
        {
            return _historyStocks.ToArray();
        }

        public void Add(CurrentStock stock)
        {
            _currentStocks.Add(stock);
        }
    }
}
