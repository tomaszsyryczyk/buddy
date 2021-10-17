using System.Threading.Tasks;
using Buddy.Events;
using Buddy.Models;
using TS.Common;

namespace Buddy.Services
{
    public class StocksEventExecutor : IHandleEventExecution<StockEvent>
    {
        private readonly IStocksRepository _stocksRepository;

        public StocksEventExecutor(IStocksRepository stocksRepository)
        {
            _stocksRepository = stocksRepository;
        }

        public async Task Execute(StockEvent toExecute)
        {
            switch (toExecute.Type)
            {
                case StockEventType.Buy:
                    AddBuy(toExecute);
                    break;
                case StockEventType.Sell:
                    AddSell(toExecute);
                    break;
            }


        }

        private void AddSell(StockEvent toExecute)
        {
            throw new System.NotImplementedException();
        }

        private void AddBuy(StockEvent toExecute)
        {
            _stocksRepository.Add(new CurrentStock(toExecute.Name,toExecute.Count,toExecute.Price,toExecute.When,default(int)));
        }
    }
}
