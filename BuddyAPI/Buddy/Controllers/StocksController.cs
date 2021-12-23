using System.Threading.Tasks;
using Buddy.Events.Stock;
using Buddy.Models;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : BuddyControllerBase
    {
        private readonly IStockRepository _stockRepository;
        private readonly IProcessEvents<StockEvent> _processStockEvents;

        public StocksController(IProcessEvents<StockEvent> processStockEvents, IStockRepository stockRepository)
        {
            _processStockEvents = processStockEvents;
            _stockRepository = stockRepository;
        }   

        [HttpPost]
        public async Task<IActionResult> StockEvent([FromBody]StockEvent stockEvent)
        {
            await _processStockEvents.Process(stockEvent);
            return new OkResult();
        }

        [HttpGet("current")]
        public Task<CurrentStock[]> Current()
        {
            var stocks = _stockRepository.Current();
            return stocks;
        }

        [HttpGet("history")]
        public Task<HistoryStock[]> History()
        {
            var stocks = _stockRepository.History();
            return stocks;
        }
    }
}
