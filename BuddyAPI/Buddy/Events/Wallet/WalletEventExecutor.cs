using System;
using System.Threading.Tasks;
using TS.Common;

namespace Buddy.Events.Wallet
{
    public class WalletEventExecutor : IHandleEventExecution<WalletEvent>
    {
        private readonly IWalletRepository _walletRepository;

        public WalletEventExecutor(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task Execute(WalletEvent toExecute)
        {
            switch (toExecute.Type)
            {
                case WalletEntryType.Expenses:
                    await AddExpenses(toExecute);
                    break;
                case WalletEntryType.Income:
                    await AddIncome(toExecute);
                    break;
                case WalletEntryType.Taxes:
                    await AddTaxes(toExecute);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async Task AddIncome(WalletEvent toExecute)
        {
            await _walletRepository.Add(toExecute);
        }

        private async Task AddExpenses(WalletEvent toExecute)
        {
            await _walletRepository.Add(toExecute);
        }

        private async Task AddTaxes(WalletEvent toExecute)
        {
            await _walletRepository.Add(toExecute);
        }
    }
}
