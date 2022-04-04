namespace BusinessLogic.Settings.Wallets.Entities
{
    public class Wallet : Entity
    {
        public Wallet(string name)
        {
            this.Name = name;
            IsDeleted = false;
        }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string name)
        {
            this.Name = name;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}
