using BusinessLogic.Settings.Wallets.Model;
using MediatR;

namespace BusinessLogic.Settings.Wallets.Messeges
{
    public class GetWallet : IRequest<WalletDetails>
    {
        public int Id { get; set; }
    }
}
