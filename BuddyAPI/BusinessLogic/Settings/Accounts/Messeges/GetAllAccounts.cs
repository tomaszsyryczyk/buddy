using BusinessLogic.Settings.Accounts.Model;
using MediatR;

namespace BusinessLogic.Settings.Accounts.Messeges
{
    public class GetAllAccounts : IRequest<AccountList>
    {
    }
}
