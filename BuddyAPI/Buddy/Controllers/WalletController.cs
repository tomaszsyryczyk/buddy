using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    [ApiController]
    [Route("api/wallet")]
    public class WalletController : BuddyControllerBase
    {

        [HttpGet("/")]
        public string Test()
        {
            return "test working";
        }

        [HttpPut("/")]
        public void Test2(string asdf)
        {
            int x = 0;
        }
        
    }
}
