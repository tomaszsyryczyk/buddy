using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buddy.Models;

namespace Buddy.Events.Wallet
{
    public class WalletRepository : IWalletRepository 
    {
        private static List<WalletEntry> _events;

        public WalletRepository()
        {
            if (_events == null)
                _events = new List<WalletEntry>();
        }

        public async Task Add(WalletEvent toExecute)
        {
            var entry = new WalletEntry(toExecute.Name, toExecute.Value, toExecute.Type, toExecute.When);

            var last = _events.OrderBy(x => x.When).LastOrDefault();
            entry.SetPreviousEntry(last);

            _events.Add(entry);
        }

        public async Task<WalletGetResponse> GetAll(WalletEventsGetRequest request)
        {
            var response = new WalletGetResponse()
            {
                Balance = _events.Sum(x => x.Value),
                Entries = _events.ToArray()
            };

            return response;
        }
    }

    public interface IWalletRepository
    {
        Task Add(WalletEvent toExecute);
        Task<WalletGetResponse> GetAll(WalletEventsGetRequest request);
    }
}
