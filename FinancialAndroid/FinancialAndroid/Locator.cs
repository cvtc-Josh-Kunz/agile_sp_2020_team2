using FinancialAndroid.Services;
using FinancialAndroid.ViewModels;
using FinancialAndroid.Views;
using System.Diagnostics;
using Xamarin.Forms;

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

        public static UserViewModel UserViewModel { get; set; }
    }
}
