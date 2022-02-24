using System.Threading.Tasks;
using BusinessLogic.Stocks;
using BusinessLogic.Stocks.Events;
using BusinessLogic.Stocks.Models;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : BuddyControllerBase
    {
        private readonly IStocksRepository _stocksRepository;

        public StocksController(IProcessEvent processEvent, IStocksRepository stocksRepository) : base(processEvent)
        {
            _stocksRepository = stocksRepository;
        }   

        [HttpPost]
        public async Task<IActionResult> StockEvent([FromBody]StockEvent stockEvent)
        {
            await ProcessEvent.Process(stockEvent);
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
