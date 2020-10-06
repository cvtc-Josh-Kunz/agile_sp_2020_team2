using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
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

            var catModels = _appService.GetCategories().ConfigureAwait(false).GetAwaiter().GetResult();
            AllCategories = _appFactory.ConvertCategories(catModels);
        }

        public ObservableCollection<CategoryViewModel> AllCategories
        {
            get => _allCategories;
            set => Set(ref _allCategories, value);
        }
        private ObservableCollection<CategoryViewModel> _allCategories = new ObservableCollection<CategoryViewModel>();

        public ObservableCollection<ExpenseViewModel> DisplayList
        {
            get => _displayList;
            set => Set(ref _displayList, value);
        }
        private ObservableCollection<ExpenseViewModel> _displayList = new ObservableCollection<ExpenseViewModel>();
    }
}
