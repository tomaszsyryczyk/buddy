using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Wallet.Model
{
    public class Source
    {
        public Source(int id, string name, SourceType type)
        {
            Id = id;
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
