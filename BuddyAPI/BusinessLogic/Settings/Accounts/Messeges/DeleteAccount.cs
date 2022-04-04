using MediatR;

namespace BusinessLogic.Settings.Accounts.Messeges
{
    public class DeleteAccount : INotification
    {
        public int Id { get; set; }
    }
}
