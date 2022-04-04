using System.Threading.Tasks;
using BusinessLogic.Settings.Wallets.Messeges;
using BusinessLogic.Settings.Wallets.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/settings/wallet")]
    public class WalletController : BuddyControllerBase
    {
        public WalletController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPut]
        public async Task Create([FromBody]CreateWallet request)
        {
            await Mediator.Publish(request);
        }

        [HttpGet("{id}")]
        public async Task<WalletDetails> Get(int id)
        {
            var result = await Mediator.Send(new GetWallet()
            {
                Id = id
            });
            return result;
        }

        [HttpGet("all")]
        public async Task<WalletList> GetAll()
        {
            var result = await Mediator.Send(new GetAllWallets());
            return result;
        }

        [HttpPost("{id}")]
        public async Task Edit(int id, [FromBody]EditWallet request)
        {
            request.Id = id;
            await Mediator.Publish(request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Mediator.Publish(new DeleteWallet()
            {
                Id = id,
            });
        }
    }
}
