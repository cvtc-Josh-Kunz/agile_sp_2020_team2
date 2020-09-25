using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using GalaSoft.MvvmLight;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class CreateUserViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        private readonly AppService _appService;
        private readonly AppFactory _appFactory;

        public CreateUserViewModel(INavigation nav)
        {
            Navigation = nav;
            _appService = DependencyService.Get<AppService>();
            _appFactory = DependencyService.Get<AppFactory>();

            CreateUserCommand = new Command(async () => { await TryCreateUser(); });
        }

        public string CreateUsername
        {
            get => _createUsername;
            set => Set(ref _createUsername, value);
        }
        private string _createUsername;

        public string CreatePassword
        {
            get => _createPassword;
            set => Set(ref _createPassword, value);
        }
        private string _createPassword;

        public string CreatePasswordVarrification
        {
            get => _createPasswordVarification;
            set => Set(ref _createPasswordVarification, value);
        }
        private string _createPasswordVarification;

        public Command CreateUserCommand { get; set; }

        public async Task TryCreateUser()
        {
            try
            {
                //_appService.InsertUser();
                throw new ArgumentNullException("");
            }
            catch
            {
                await Locator.CreateUserView.DisplayAlert("Failed", "Try again", "OK");
            }

        }
    }
}
