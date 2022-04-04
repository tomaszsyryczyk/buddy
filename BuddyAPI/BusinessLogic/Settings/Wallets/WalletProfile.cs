using AutoMapper;
using BusinessLogic.Settings.Wallets.Entities;
using BusinessLogic.Settings.Wallets.Model;

namespace BusinessLogic.Settings.Wallets
{
    public class WalletProfile : Profile
    {
        public WalletProfile()
        {
            CreateMap<Wallet, WalletDetails>();
        }
    }
}
