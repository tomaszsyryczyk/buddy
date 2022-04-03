using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Messages;
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

        [HttpPost]
        public async Task Edit([FromBody]EditFixedExpense request)
        {
            await Mediator.Publish(request);
        }

        [HttpDelete]
        public async Task Delete([FromBody]DeleteFixedExpense request)
        {
            await Mediator.Publish(request);
        }

    }
}
