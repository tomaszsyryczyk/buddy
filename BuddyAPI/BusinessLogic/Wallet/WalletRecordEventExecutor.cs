using System;
using System.Threading.Tasks;
using BusinessLogic.Wallet.Events;
using TS.Common;

namespace BusinessLogic.Wallet
{
    internal class WalletRecordEventExecutor : IHandleEventExecution<WalletRecordEvent>
    {
        public Task Execute(WalletRecordEvent toExecute)
        {
            throw new NotImplementedException();
        }
    }
}
