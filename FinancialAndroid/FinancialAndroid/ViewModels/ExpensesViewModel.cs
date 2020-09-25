using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class ExpensesViewModel : ViewModelBase
    {
        private INavigation Navigation { get; set; }
        private readonly AppService _appService;
        private readonly AppFactory _appFactory;

        public ExpensesViewModel(INavigation nav)
        {
            Navigation = nav;
            _appService = DependencyService.Get<AppService>();
            _appFactory = DependencyService.Get<AppFactory>();
        }
    }
}
