using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class ExpensesViewModel : ViewModelBase
    {
        private INavigation Navigation { get; set; }

        public ExpensesViewModel(INavigation nav)
        {
            Navigation = nav;
        }
    }
}
