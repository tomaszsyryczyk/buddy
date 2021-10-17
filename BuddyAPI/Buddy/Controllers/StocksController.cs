using System;
using System.Threading.Tasks;
using Buddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController
    {
        public StocksController()
        {
            
        }

        [HttpPost]
        public async Task Create(CreateStockEvent createEvent)
        {

        }

        [HttpGet("current")]
        public CurrentStock[] Current()
        {
            return new CurrentStock[]
            {
                new CurrentStock("CDPR",5,172.5,DateTimeOffset.Now, 174.50),
                new CurrentStock("KGHM",10,1.5,DateTimeOffset.Now, 174.51),
                new CurrentStock("PZU",15,17.5,DateTimeOffset.Now, 174.52),
                new CurrentStock("PKOBP",20,12.5,DateTimeOffset.Now, 174.53),
                new CurrentStock("CDPR",52,999,DateTimeOffset.Now, 174.54),
            };
        }

        [HttpGet("history")]
        public void History()
        {
        }
    }
}
