using GalaSoft.MvvmLight;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }

        public LoginViewModel(INavigation nav)
        {
            Navigation = nav;
            LoginCommand = new Command(async () => await LoginCommandMethod());
            CreateUserCommand = new Command(async () => await CreateUserCommandMethod());
        }
        public string Username
        {
            get => _username;
            set => Set(ref _username, value);
        }
        private string _username;

        public string Password
        {
            get => _password;
            set => Set(ref _password, value);
        }
        private string _password;

        public ICommand LoginCommand { get; set; }
        public ICommand CreateUserCommand { get; set; }

        public async Task LoginCommandMethod()
        {
            await Navigation.PushAsync(Locator.ExpensesView);
        }

        public async Task CreateUserCommandMethod()
        {
            await Navigation.PushAsync(Locator.CreateUserView);
        }
    }
}
