using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController
    {

        [HttpGet("current")]
        public string Current()
        {
            return "test";
        }

        [HttpGet("history")]
        public void History()
        {
        }
    }
}
