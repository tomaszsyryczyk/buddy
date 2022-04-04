using MediatR;

namespace BusinessLogic.Settings.Accounts.Messeges
{
    public class CreateAccount : INotification
    {
        public string Name { get; set; }
        public string IBAN { get; set; }
    }
}
