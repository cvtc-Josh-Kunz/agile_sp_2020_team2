using FinancialAndroid.ViewModels;
using FinancialAndroid.Views;
using System.Collections.ObjectModel;

namespace FinancialAndroid
{
    public static class Locator
    {
        #region Views
        public static LoginView LoginView { get; set; }
        public static CreateUserView CreateUserView { get; set; }
        public static ExpensesView ExpensesView { get; set; }
        public static CategoryView CategoryView { get; set; }
        public static CreateCategoryView CreateCategoryView { get; set; }
        public static CreateExpenseView CreateExpenseView { get; set; }
        #endregion

        public static UserViewModel UserViewModel { get; set; }

        #region Categories

        public static ObservableCollection<CategoryViewModel> AllCategories { get; set; }
        #endregion
    }
}
