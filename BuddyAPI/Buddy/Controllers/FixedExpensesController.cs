using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Messages;
using BusinessLogic.Settings.FixedExpenses.Model;
using DataLayer.Settings.FixedExpenses.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{

    [ApiController]
    [Route("api/settings/fixed-expenses")]
    public class FixedExpensesController : BuddyControllerBase
    {
        public FixedExpensesController(IMediator mediator) : base(mediator)
        {
            
        }

        [HttpPut]
        public async Task Create([FromBody]CreateFixedExpense request)
        {
            await Mediator.Publish(request);
        }

        [HttpGet("{id}")]
        public async Task<FixedExpenseDetails> Get(int id)
        {
            var result = await Mediator.Send(new GetFixedExpense(id));
            return result;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<FixedExpenseDetails>> GetAll()
        {
            var result = await Mediator.Send(new GetAllFixedExpense());
            return result;
        }

        [HttpPost("{id}")]
        public async Task Edit(int id,[FromBody]EditFixedExpense request)
        {
            request.Id = id;
            await Mediator.Publish(request);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Mediator.Publish(new DeleteFixedExpense()
            {
                Id = id,
            });
        }

        [HttpGet("summary")]
        public async Task<FixedExpenseSummaryDetails> Summary()
        {
            var result = await Mediator.Send(new FixedExpenseSummary());
            return result;
        }

    }
}
