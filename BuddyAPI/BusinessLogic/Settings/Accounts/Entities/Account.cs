namespace BusinessLogic.Settings.Accounts.Entities
{
    public class Account : Entity
    {
        public Account(string name, string iban)
        {
            this.Name = name;
            this.Iban = iban;
        }

        public string Name { get; set; }
        public string Iban { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string name, string iban)
        {
            this.Name = name;
            this.Iban = iban;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}
