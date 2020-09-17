using GalaSoft.MvvmLight;

namespace FinancialAppp.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public int UserId
        {
            get => _userId;
            set => Set(ref _userId, value);
        }
        private int _userId;

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
    }
}
