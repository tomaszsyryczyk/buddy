using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    public abstract class BuddyControllerBase : ControllerBase
    {
        public IMediator Mediator { get; set; }
    }
}
