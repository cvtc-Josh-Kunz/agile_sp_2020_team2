using FinancialAppp.Database.Tables;
using FinancialAppp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace FinancialAppp.Factory
{
    public class AppFactory
    {
        public UserViewModel ConvertUser(User user) => new UserViewModel
        {
            UserId = user.UserId,
            Username = user.Username,
            Password = user.Password
        };

        public IEnumerable<ExpenseViewModel> ConvertMultipleExpenses(List<Expense> expenses) =>
            expenses.Select(ConvertExpense);

        public ExpenseViewModel ConvertExpense(Expense expense) => new ExpenseViewModel
        {
            ExpenseId = expense.ExpenseId,
            CategoryId = expense.CategoryId,
            UserId = expense.UserId,
            Amount = expense.Amount,
            Date = expense.Date
        };
    }
}
