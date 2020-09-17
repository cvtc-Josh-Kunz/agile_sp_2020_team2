using FinancialAppp.Database.Tables;
using FinancialAppp.Factory;
using FinancialAppp.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;

namespace FinancialAppp.ViewModels
{
    public class ExpensePageViewModel : ViewModelBase
    {
        private readonly AppServices _services;
        private readonly AppFactory _factory;
        private readonly IMessenger _messenger;

        public ExpensePageViewModel(AppServices services, AppFactory factory, IMessenger messenger)
        {
            _services = services;
            _factory = factory;
            _messenger = messenger;
        }

        #region Properties
        public UserViewModel User
        {
            get => _user;
            set
            {
                Set(ref _user, value);

                if (value == null)
                    return;

                //get the data from database and fill the expenses collection in the view.
            }
        }
        private UserViewModel _user;

        public ObservableCollection<ExpenseViewModel> Expenses
        {
            get => _expenses;
            set => Set(ref _expenses, value);
        }
        private ObservableCollection<ExpenseViewModel> _expenses;

        #endregion
    }
}
