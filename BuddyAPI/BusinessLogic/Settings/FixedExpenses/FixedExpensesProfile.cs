using AutoMapper;
using BusinessLogic.Settings.FixedExpenses.Entities;
using DataLayer.Settings.FixedExpenses.Model;

namespace DataLayer.FixedExpenses
{
    public class FixedExpensesProfile : Profile
    {
        public FixedExpensesProfile()
        {
            CreateMap<FixedExpense, FixedExpenseDetails>();
        }
    }
}
