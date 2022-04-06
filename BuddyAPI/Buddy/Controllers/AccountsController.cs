using System.Threading.Tasks;
using BusinessLogic.Settings.Accounts.Messeges;
using BusinessLogic.Settings.Accounts.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/settings/accounts")]
    public class AccountsController : BuddyControllerBase
    {
        public AccountsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPut]
        public async Task Create([FromBody]CreateAccount request)
        {
            await Mediator.Publish(request);
        }

        [HttpGet("{id}")]
        public async Task<AccountDetails> Get(int id)
        {
            var result = await Mediator.Send(new GetAccount()
            {
                Id = id
            });
            return result;
        }

        [HttpGet("list")]
        public async Task<AccountList> GetAll()
        {
            var result = await Mediator.Send(new GetAllAccounts());
            return result;
        }

        [HttpPost("{id}")]
        public async Task Edit(int id, [FromBody]EditAccount request)
        {
            request.Id = id;
            await Mediator.Publish(request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Mediator.Publish(new DeleteAccount()
            {
                Id = id,
            });
        }
    }
}
