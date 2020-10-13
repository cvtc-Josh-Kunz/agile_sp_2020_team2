using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class CreateCategoryViewModel : ViewModelBase
    {
        private readonly AppFactory _appFactory;
        private readonly AppService _appService;

        private INavigation Navigation { get; set; }

        public CreateCategoryViewModel(INavigation nav)
        {
            _appFactory = DependencyService.Get<AppFactory>();
            _appService = DependencyService.Get<AppService>();
            Navigation = nav;

            AddCategoryCommand = new Command(async () => await AddCategoryCommandMethod());
        }

        public ObservableCollection<CategoryViewModel> DisplayList
        {
            get => _displayList;
            set => Set(ref _displayList, value);
        }
        private ObservableCollection<CategoryViewModel> _displayList = new ObservableCollection<CategoryViewModel>();

        public string NewEntry
        {
            get => _newEntry;
            set => Set(ref _newEntry, value);
        }
        private string _newEntry;

        public string Message
        {
            get => _message;
            set => Set(ref _message, value);
        }
        private string _message;

        public Command AddCategoryCommand { get; private set; }

        public async Task AddCategoryCommandMethod()
        {
            var hasPassed = await _appService.TryCreateCategory(NewEntry);

            if (hasPassed)
            {
                Message = $"{NewEntry} was created.";
            }
            else
            {
                Message = $"Failed to create {NewEntry}.";
            }
        }
    }
}
