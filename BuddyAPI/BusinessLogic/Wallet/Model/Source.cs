namespace BusinessLogic.Wallet.Model
{
    public class Source
    {
        public Source(string name, SourceType type)
        {
            Name = name;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public SourceType Type { get; set; }
    }

    public enum SourceType
    {
        Wallet = 0,
        Account = 1
    }
}
