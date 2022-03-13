using TS.Common;

namespace BusinessLogic.Wallet.Events
{
    public class AddSourceEvent : Event
    {
        public AddSourceType Type { get; set; }

        public string Name { get; set; }
    }
}
