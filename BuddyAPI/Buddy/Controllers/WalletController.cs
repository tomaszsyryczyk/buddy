using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/wallet")]
    public class WalletController : BuddyControllerBase
    {

        public WalletController(IProcessEvent processEvent) : base(processEvent)
        {
        }

        [HttpPut]
        public async Task<IActionResult> AddEntry([FromBody]WalletRecordEvent recordEvent)
        {
            await ProcessEvent.Process(recordEvent);
            return new OkResult();
        }
    }
}
