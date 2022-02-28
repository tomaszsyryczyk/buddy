using System.Threading.Tasks;
using BusinessLogic.Wallet;
using BusinessLogic.Wallet.Events;
using BusinessLogic.Wallet.Model;
using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/wallet")]
    public class WalletController : BuddyControllerBase
    {
        private readonly ISourceRepository _sourceRepository;

        public WalletController(IProcessEvent processEvent, ISourceRepository sourceRepository) : base(processEvent)
        {
            _sourceRepository = sourceRepository;
        }

        [HttpPut]
        public async Task<IActionResult> AddEntry([FromBody]WalletRecordEvent recordEvent)
        {
            await ProcessEvent.Process(recordEvent);
            return new OkResult();
        }

        [HttpPut]
        [Route("source")]
        public async Task<IActionResult> AddSource([FromBody]AddSourceEvent sourceEvent)
        {
            await ProcessEvent.Process(sourceEvent);
            return new OkResult();
        }

        [HttpGet]
        [Route("source/{id}")]
        public async Task<Source> GetSource(int id)
        {
            var result = await _sourceRepository.Get(id);
            return result;
        }

        [HttpGet]
        [Route("source/list")]
        public async Task<Source[]> GetAllSources()
        {
            var result = await _sourceRepository.GetAll();
            return result;
        }

        [HttpPost]
        [Route("source/{id}")]
        public async Task<IActionResult> EditSource(int id,[FromBody]EditSourceEvent sourceEvent)
        {
            sourceEvent.Id = id;
            await ProcessEvent.Process(sourceEvent);
            return new OkResult();
        }

        [HttpDelete]
        [Route("source/{id}")]
        public async Task<IActionResult> DeleteSource(int id)
        {
            var sourceEvent = new DeleteSourceEvent(id);
            await ProcessEvent.Process(sourceEvent);
            return new OkResult();
        }
    }
}
