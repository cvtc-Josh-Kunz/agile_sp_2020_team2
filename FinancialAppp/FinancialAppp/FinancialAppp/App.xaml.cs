using FinancialAppp.Database;
using FinancialAppp.Factory;
using FinancialAppp.Locators;
using FinancialAppp.Services;
using FinancialAppp.ViewModels;
using FinancialAppp.Views;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.IO;
using FinancialAppp.Classes;
using Xamarin.Forms;
using FinancialAppp.Extensions;

namespace FinancialAppp
{
    public partial class App : Application
    {
        private readonly IMessenger _messenger;
        private readonly AppFactory _factory;
        private readonly AppServices _services;

        public App()
        {
            InitializeComponent();

            _services = new AppServices();
            _factory = new AppFactory();
            _messenger = new Messenger();

            #region Locator
            ViewModelLocator.LoginViewModel = new LoginViewModel(_services, _factory, _messenger);
            ViewModelLocator.ExpensePageViewModel = new ExpensePageViewModel(_services, _factory, _messenger);
            #endregion

            var loginView = new LoginView
            {
                BindingContext = ViewModelLocator.LoginViewModel
            };

            MainPage = loginView;

            #region Messeges
            _messenger.RegisterMessageListener(this, Messages.SwitchToExpenseView, SwitchToExpenseView);
            #endregion
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
        private void SwitchToExpenseView(NotificationMessage message)
        {
            var vm = ViewModelLocator.ExpensePageViewModel;
            vm.User = ViewModelLocator.UserViewModel;

            var view = new ExpensesView
            {
                BindingContext = vm
            };

            MainPage = view;
        }
        #endregion
    }
}
