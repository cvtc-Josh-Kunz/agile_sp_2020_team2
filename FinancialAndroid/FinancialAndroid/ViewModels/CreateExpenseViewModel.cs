using FinancialAndroid.Factory;
using FinancialAndroid.Models;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class CreateExpenseViewModel : ViewModelBase
    {
        public INavigation Navigation { get; private set; }

        private readonly AppService _appService;
        private readonly AppFactory _appFactory;

        public CreateExpenseViewModel(INavigation nav)
        {
            Navigation = nav;

            _appService = DependencyService.Get<AppService>();
            _appFactory = DependencyService.Get<AppFactory>();

            CreateExpenseCommand = new Command(async () => await CreateExpenseCommandMethodAsync());
        }

        public Command CreateExpenseCommand { get; private set; }

        public async Task CreateExpenseCommandMethodAsync()
        {
            //create a new expense in the database

            var newExpense = new Expense()
            {

            };

            //await _appService.CreateExpense(newExpense);
        }
    }
}
