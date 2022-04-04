using MediatR;

namespace BusinessLogic.Settings.Wallets.Messeges
{
    public class DeleteWallet : INotification
    {
        public int Id { get; set; }
    }
}
