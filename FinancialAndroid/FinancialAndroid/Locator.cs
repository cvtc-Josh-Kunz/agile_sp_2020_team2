using FinancialAndroid.Services;
using FinancialAndroid.Views;

namespace FinancialAndroid
{
    public static class Locator
    {
        #region Views
        public static LoginView LoginView { get; set; }
        public static CreateUserView CreateUserView { get; set; }
        public static ExpensesView ExpensesView { get; set; }
        public static CategoryView CategoryView { get; set; }
        #endregion
    }
}
