using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Buddy.Events;
using Buddy.Models;
using TS.Common;

namespace Buddy.Services
{
    public interface IStocksProvider
    {
        Task<CurrentStock[]> Current();
        Task<HistoryStock[]> History();
    }

    public class StocksProvider : IStocksProvider
    {
        private readonly IMediateEvents<StockEvent> _mediateStockEvents;

        public StocksProvider(IMediateEvents<StockEvent> mediateStockEvents)
        {
            _mediateStockEvents = mediateStockEvents;
        }

        public async Task<CurrentStock[]> Current()
        {
            var current = new List<StockEvent>();
            var allStocks = await _mediateStockEvents.All();

            
            
            return new CurrentStock[]
            {
                new CurrentStock("cdpr", 10, 172.2 , DateTimeOffset.Now, 190 ),
                new CurrentStock("cdpr1", 5, 1712.2 , DateTimeOffset.Now, 192 ),
                new CurrentStock("cdpr2", 4, 1732.2 , DateTimeOffset.Now, 193 ),
                new CurrentStock("cdpr3", 2, 1472.2 , DateTimeOffset.Now, 194 ),
            };
        }

        public async Task<HistoryStock[]> History()
        {
            var current = new List<StockEvent>();
            var allStocks = await _mediateStockEvents.All();

            return new HistoryStock[]
            {
                new HistoryStock()
                {
                    BuyStocks = new List<BuyHistoryStock>(),
                    SellStocks = new List<SellHistoryStock>()
                }, 
            };

        }
    }
}
