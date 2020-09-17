using FinancialAppp.Factory;
using FinancialAppp.Factory.Abstractions;
using FinancialAppp.Locators;
using FinancialAppp.Services;
using FinancialAppp.Services.Abstractions;
using FinancialAppp.ViewModels;
using FinancialAppp.Views;
using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;

namespace FinancialAppp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            IAppServices services = new AppServices();
            IAppFactory factory = new AppFactory();
            IMessenger messenger = new Messenger();

            #region Locator
            ViewModelLocator.LoginViewModel = new LoginViewModel(services, factory, messenger);

            #endregion

            var loginView = new LoginView
            {
                BindingContext = ViewModelLocator.LoginViewModel
            };

            MainPage = loginView;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #region Messages

        #endregion
    }
}
