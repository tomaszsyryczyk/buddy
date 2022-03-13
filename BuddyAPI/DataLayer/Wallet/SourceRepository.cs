using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Wallet;
using BusinessLogic.Wallet.Events;
using BusinessLogic.Wallet.Model;

namespace DataLayer.Wallet
{
    internal class SourceRepository : ISourceRepository
    {
        private static List<Source> _sources ;

        public SourceRepository()
        {
            if (_sources == null)
                _sources = new List<Source>();
        }

        public async Task Add(AddSourceType type, string name)
        {
            var newId = _sources.Any() ? _sources.Max(x => x.Id) + 1 : 1;
            var toAdd = new Source(newId, name, Map(type));
            _sources.Add(toAdd);
        }

        public async Task Edit(int id, AddSourceType newType, string newName)
        {
            if (_sources.Exists(x => x.Id == id))
            {
                var index = _sources.FindIndex(x => x.Id == id);
                _sources[index].Name = newName;
                _sources[index].Type = Map(newType);
            }
        }

        public async Task Remove(int id)
        {
            if (_sources.Exists(x => x.Id == id))
            {
                var index = _sources.FindIndex(x => x.Id == id);
                _sources.RemoveAt(index);
            }
        }

        public async Task<Source> Get(int id)
        {
            return _sources.Find(x => x.Id == id);
        }

        public async Task<Source[]> GetAll()
        {
            return _sources.ToArray();
        }

        private SourceType Map(AddSourceType type)
        {
            var dict = new Dictionary<AddSourceType, SourceType>()
            {
                {AddSourceType.Wallet, SourceType.Wallet },
                { AddSourceType.Account, SourceType.Account}
            };

            return dict[type];
        }
    }
}
