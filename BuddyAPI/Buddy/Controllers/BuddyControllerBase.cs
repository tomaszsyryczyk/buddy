using Microsoft.AspNetCore.Mvc;
using TS.Common;

namespace Buddy.Controllers
{
    public abstract class BuddyControllerBase : ControllerBase
    {
        protected IProcessEvent ProcessEvent;

        protected BuddyControllerBase(IProcessEvent processEvent)
        {
            ProcessEvent = processEvent;
        }
    }
}
