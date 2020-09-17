using FinancialAppp.ViewModels;
using FinancialAppp.Views;

namespace FinancialAppp.Locators
{
    public static class ViewModelLocator
    {
        public static UserViewModel UserViewModel { get; set; }
        public static LoginViewModel LoginViewModel { get; set; }
        public static ExpensePageViewModel ExpensePageViewModel { get; set; }
    }
}
