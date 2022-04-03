using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Settings.FixedExpenses.Entities;

namespace BusinessLogic.Settings.FixedExpenses
{
    public interface IFixedExpenseRepository
    {
        Task Add(FixedExpense fixedExpense);

        Task<IEnumerable<FixedExpense>> All();
        Task Delete(int notificationId);
        Task<FixedExpense> Get(int requestId);
    }
}
