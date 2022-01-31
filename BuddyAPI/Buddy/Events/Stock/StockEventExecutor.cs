using System.Threading.Tasks;
using Buddy.Models;
using TS.Common;

namespace Buddy.Events.Stock
{
    public class StockEventExecutor : IHandleEventExecution<StockEvent>
    {
        private readonly IStockRepository _stockRepository;

        public StockEventExecutor(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
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
            _stockRepository.Add(new CurrentStock(toExecute.Name,toExecute.Count,toExecute.Price,toExecute.When,default(int)));
        }
    }
}
