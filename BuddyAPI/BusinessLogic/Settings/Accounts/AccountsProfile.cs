using AutoMapper;
using BusinessLogic.Settings.Accounts.Entities;
using BusinessLogic.Settings.Accounts.Model;

namespace BusinessLogic.Settings.Accounts
{
    public class AccountsProfile : Profile
    {
        public AccountsProfile()
        {
            CreateMap<Account, AccountDetails>();
        }
    }
}
