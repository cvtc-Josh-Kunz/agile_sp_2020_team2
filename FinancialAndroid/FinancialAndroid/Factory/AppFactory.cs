using FinancialAndroid.Models;
using FinancialAndroid.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace FinancialAndroid.Factory
{
    public class AppFactory
    {
        public UserViewModel ConvertUser(User user)
        {
            return new UserViewModel()
            {
                UserId = user.Id,
                Username = user.Username
            };
        }

        public ExpenseViewModel ConvertExpense(Expense e)
        {
            return new ExpenseViewModel()
            {
                Id = e.Id,
                UserId = e.UserId,
                CategoryId = e.CategoryId,
                Amount = e.Amount,
                Date = e.Date
            };
        }

        public List<ExpenseViewModel> ConvertExpenses(List<Expense> e)
        {
            return e.Select(ConvertExpense).ToList();
        }

        public CategoryViewModel ConvertCategory(Category c)
        {
            return new CategoryViewModel()
            {
                Id = c.Id,
                CategoryName = c.CategoryName
            };
        }

        public List<CategoryViewModel> ConvertCategories(List<Category> c)
        {
            return c.Select(ConvertCategory).ToList();
        }
    }
}
