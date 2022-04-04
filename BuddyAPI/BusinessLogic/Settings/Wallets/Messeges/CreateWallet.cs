using MediatR;

namespace BusinessLogic.Settings.Wallets.Messeges
{
    public class CreateWallet : INotification
    {
        public string Name { get; set; }
    }
}
