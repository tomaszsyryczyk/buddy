using TS.Common;

namespace BusinessLogic.Wallet.Events
{
    public class EditSourceEvent : Event
    {
        public int Id { get; set; }
        public AddSourceType Type { get; set; }
        public string Name { get; set; }
    }
}
