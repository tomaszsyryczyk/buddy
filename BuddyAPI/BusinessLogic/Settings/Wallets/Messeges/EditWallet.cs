using MediatR;

namespace BusinessLogic.Settings.Wallets.Messeges
{
    public class EditWallet : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
