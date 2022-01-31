using System.Threading.Tasks;
using Buddy.Events.Wallet;
using Buddy.Models;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/wallet")]
    public class WalletController
    {
        private readonly IProcessEvents<WalletEvent> _processWalletEvents;
        private readonly IWalletRepository _walletRepository;

        public WalletController(IProcessEvents<WalletEvent> processWalletEvents, IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
            _processWalletEvents = processWalletEvents;
        }

        [HttpPost]
        public async Task<IActionResult> WalletEvent([FromBody]WalletEvent stockEvent)
        {
            await _processWalletEvents.Process(stockEvent);
            return new OkResult();
        }

        [HttpGet("all")]
        public async Task<WalletGetResponse> Get([FromQuery]WalletEventsGetRequest request)
        {
            var response = await _walletRepository.GetAll(request);
            
            return response;
        }

    }
}
