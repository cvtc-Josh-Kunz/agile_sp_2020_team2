using FinancialAppp.Factory;
using FinancialAppp.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FinancialAppp.Classes;
using FinancialAppp.Extensions;
using FinancialAppp.Locators;

namespace FinancialAppp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly AppServices _services;
        private readonly AppFactory _factory;
        private readonly IMessenger _messenger;

        public LoginViewModel(AppServices services, AppFactory factory, IMessenger messenger)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            _messenger = messenger ?? throw new ArgumentNullException(nameof(messenger));

            LoginCommand = new RelayCommand(LoginCommandMethod);
            CreateUserCommand = new RelayCommand(CreateUserCommandMethod);
        }

        #region Properties
        public string UsernameText
        {
            get => _usernameText;
            set => Set(ref _usernameText, value);
        }
        private string _usernameText;

        public string PasswordText
        {
            get => _passwordText;
            set => Set(ref _passwordText, value);
        }
        private string _passwordText;

        public string MessageText
        {
            get => _messageText;
            set => Set(ref _messageText, value);
        }
        private string _messageText;
        #endregion


        #region Button Commands
        public ICommand LoginCommand { get; set; }
        public ICommand CreateUserCommand { get; set; }
        #endregion

        #region Command Methods
        public void LoginCommandMethod()
        {
            var userModel = AppServices.Database.GetUserAsync(UsernameText, PasswordText)
                .ConfigureAwait(false).GetAwaiter().GetResult();

            if (userModel == null)
            {
                MessageText = "Username or password are incorrect.";
                return;
            }

            ViewModelLocator.UserViewModel = _factory.ConvertUser(userModel);

            _messenger.SendMessage(Messages.SwitchToExpenseView);
        }

        public void CreateUserCommandMethod()
        {
            try
            {
                var userCreated = AppServices.Database.CreateNewUser(UsernameText, PasswordText)
                    .ConfigureAwait(false).GetAwaiter().GetResult();

                MessageText = "New User created!";
            }
            catch (Exception e)
            {
                MessageText = "User could not be created, try again.";
            }
        }
        #endregion
    }
}
