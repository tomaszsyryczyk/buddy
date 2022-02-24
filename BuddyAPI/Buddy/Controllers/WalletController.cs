using BusinessLogic.Stocks;
using BusinessLogic.Stocks.Events;
using Microsoft.AspNetCore.Mvc;
using TS.Common;


namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/wallet")]
    public class WalletController : BuddyControllerBase
    {
        //private readonly IMediateEvents<StockEvent> _mediateStockEvents;

        public WalletController()
        {
        }

    }
}
