using MediatR;

namespace BusinessLogic.Registers.Messages
{
    public class DeleteRegistry : INotification
    {
        public int Id { get; set; }
    }
}
