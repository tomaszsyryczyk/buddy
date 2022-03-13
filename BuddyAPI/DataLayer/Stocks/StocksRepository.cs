using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Stocks;
using BusinessLogic.Stocks.Models;

namespace DataLayer.Stocks
{
    public class StocksRepository : IStocksRepository
    {
        private static List<CurrentStock> _currentStocks;
        private static List<HistoryStock> _historyStocks;

        public StocksRepository()
        {
            if (_currentStocks == null)
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
