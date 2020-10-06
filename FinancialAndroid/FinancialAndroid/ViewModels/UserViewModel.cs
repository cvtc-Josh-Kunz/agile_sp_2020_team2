using GalaSoft.MvvmLight;

namespace FinancialAndroid.ViewModels
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
    }
}
