using TS.Common;

namespace BusinessLogic.Wallet.Events
{
    public class AddSourceEvent : Event
    {
        public AddSourceEventType Type { get; set; }

        public string Name { get; set; }
    }
}
