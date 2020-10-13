using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
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
            var catVMs = _appFactory.ConvertCategories(catModels);

            AllCategories.Clear();

            foreach (var cat in catVMs)
            {
                AllCategories.Add(cat);
            }

            AllCategories.Add(new CategoryViewModel() { CategoryName = "None"});

            AddExpenseCommand = new Command(async () => await AddExpenseCommandMethod());
            AddCategoryCommand = new Command(async () => await AddCategoryCommandMethod());
        }

        public Command AddExpenseCommand { get; private set; }
        public Command AddCategoryCommand { get; private set; }

        public ObservableCollection<CategoryViewModel> AllCategories
        {
            get => _allCategories;
            set => Set(ref _allCategories, value);
        }
        private ObservableCollection<CategoryViewModel> _allCategories = new ObservableCollection<CategoryViewModel>();

        public CategoryViewModel SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                //if changed than update the display list.

                Set(ref _selectedCategory, value);
            }
        }
        private CategoryViewModel _selectedCategory;

        public ObservableCollection<ExpenseViewModel> DisplayList
        {
            get => _displayList;
            set => Set(ref _displayList, value);
        }
        private ObservableCollection<ExpenseViewModel> _displayList = new ObservableCollection<ExpenseViewModel>();

        public async Task AddExpenseCommandMethod()
        {
            await Navigation.PushAsync(Locator.CreateExpenseView);
        }

        public async Task AddCategoryCommandMethod()
        {
            await Navigation.PushAsync(Locator.CreateCategoryView);
        }
    }
}
