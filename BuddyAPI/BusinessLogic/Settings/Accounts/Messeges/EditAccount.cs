using MediatR;

namespace BusinessLogic.Settings.Accounts.Messeges
{
    public class EditAccount : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IBAN { get; set; }
    }
}
