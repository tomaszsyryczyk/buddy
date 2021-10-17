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
        private readonly IStocksRepository _stocksRepository;
        private readonly IMediateEvents<StockEvent> _mediateStockEvents;

        public StocksController(IMediateEvents<StockEvent> mediateStockEvents, IStocksRepository stocksRepository)
        {
            _mediateStockEvents = mediateStockEvents;
            _stocksRepository = stocksRepository;
        }   

        [HttpPost]
        public async Task<IActionResult> StockEvent([FromBody]StockEvent stockEvent)
        {
            await _mediateStockEvents.Persist(stockEvent);
            await _mediateStockEvents.Execute(stockEvent);
            return new OkResult();
        }

        [HttpGet("current")]
        public Task<CurrentStock[]> Current()
        {
            var stocks = _stocksRepository.Current();
            return stocks;
        }

        [HttpGet("history")]
        public Task<HistoryStock[]> History()
        {
            var stocks = _stocksRepository.History();
            return stocks;
        }
    }
}
