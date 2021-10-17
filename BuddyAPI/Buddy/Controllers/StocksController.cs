using System;
using System.Threading.Tasks;
using Buddy.Events;
using Buddy.Models;
using Buddy.Services;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : BuddyControllerBase
    {
        private readonly IStocksProvider _stocksProvider;
        private readonly IMediateEvents<StockEvent> _mediateStockEvents;

        public StocksController(IMediateEvents<StockEvent> mediateStockEvents, IStocksProvider stocksProvider)
        {
            _mediateStockEvents = mediateStockEvents;
            _stocksProvider = stocksProvider;
        }   

        [HttpPost]
        public async Task<IActionResult> StockEvent([FromBody]StockEvent stockEvent)
        {
            await _mediateStockEvents.Persist(stockEvent);
            return new OkResult();
        }

        [HttpGet("current")]
        public Task<CurrentStock[]> Current()
        {
            var stocks = _stocksProvider.Current();
            return stocks;
        }

        [HttpGet("history")]
        public Task<HistoryStock[]> History()
        {
            var stocks = _stocksProvider.History();
            return stocks;
        }
    }
}
