using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using FinancialAndroid.Views;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        private readonly AppService _appService;
        private readonly AppFactory _appFactory;

        public LoginViewModel(INavigation nav)
        {
            Navigation = nav;

            _appService = DependencyService.Get<AppService>();
            _appFactory = DependencyService.Get<AppFactory>();

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
            //check if username/password exist in database
            var user = await _appService.GetUserByCredentials(Username, Password);

            if(user != null)
            {
                Locator.UserViewModel = _appFactory.ConvertUser(user);
                await Navigation.PushAsync(Locator.ExpensesView);
                return;
            }
            else
            {
                await Locator.LoginView.DisplayAlert("Invalid Credentials", "Username or password are incorrect\nTry again.", "OK");
            }
        }

        public async Task CreateUserCommandMethod()
        {
            await Navigation.PushAsync(Locator.CreateUserView);
        }
    }
}
