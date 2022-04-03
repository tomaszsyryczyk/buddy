using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Buddy.Controllers
{
    public abstract class BuddyControllerBase : ControllerBase
    {
        public readonly IMediator Mediator;

        protected BuddyControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
