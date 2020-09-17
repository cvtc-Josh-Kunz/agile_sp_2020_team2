using FinancialAppp.Factory.Abstractions;
using FinancialAppp.Services.Abstractions;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows.Input;

namespace FinancialAppp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IAppServices _services;
        private readonly IAppFactory _factory;
        private readonly IMessenger _messenger;

        public LoginViewModel(IAppServices services, IAppFactory factory, IMessenger messenger)
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
        #endregion


        #region Button Commands
        public ICommand LoginCommand { get; set; }
        public ICommand CreateUserCommand { get; set; }
        #endregion

        #region Command Methods
        public void LoginCommandMethod()
        {
            UsernameText = "Command Working";
        }

        public void CreateUserCommandMethod()
        {

        }
        #endregion
    }
}
