using TS.Common;

namespace BusinessLogic.Wallet.Events
{
    public class DeleteSourceEvent : Event
    {
        public DeleteSourceEvent(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
