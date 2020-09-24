using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class CreateUserViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }

        public CreateUserViewModel(INavigation nav)
        {
            Navigation = nav;
        }
    }
}
