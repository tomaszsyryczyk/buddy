using System;
using System.Threading.Tasks;
using BusinessLogic.Registers.Messages;
using BusinessLogic.Registers.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{

    [ApiController]
    [Route("api/registry")]
    public class RegistryController : BuddyControllerBase
    {
        public RegistryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPut]
        public async Task Create([FromBody] CreateRegistry request)
        {
            await Mediator.Publish(request);
        }

        [HttpGet("{id}")]
        public async Task<RegistryDetails> Get(int id)
        {
            var result = await Mediator.Send(new GetRegistry()
            {
                Id = id
            });
            return result;
        }

        [HttpGet("list")]
        public async Task<RegistryList> GetAll(DateTimeOffset from, DateTimeOffset to )
        {
            var request = new GetRegistryList()
            {
                From = from,
                To = to
            };
            var result = await Mediator.Send(request);
            return result;
        }

        [HttpPost("{id}")]
        public async Task Edit(int id, [FromBody] EditRegistry request)
        {
            request.Id = id;
            await Mediator.Publish(request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Mediator.Publish(new DeleteRegistry()
            {
                Id = id,
            });
        }
    }
}
