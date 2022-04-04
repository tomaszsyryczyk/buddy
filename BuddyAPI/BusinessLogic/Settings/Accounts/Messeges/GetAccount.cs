using BusinessLogic.Settings.Accounts.Model;
using MediatR;

namespace BusinessLogic.Settings.Accounts.Messeges
{
    public class GetAccount : IRequest<AccountDetails>
    {
        public int Id { get; set; }
    }
}
