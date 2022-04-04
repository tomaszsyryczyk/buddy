using BusinessLogic.Settings.Wallets.Model;
using MediatR;

namespace BusinessLogic.Settings.Wallets.Messeges
{
    public class GetAllWallets : IRequest<WalletList>
    {
    }
}
