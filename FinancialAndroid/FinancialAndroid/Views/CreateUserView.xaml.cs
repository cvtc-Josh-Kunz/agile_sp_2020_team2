using FinancialAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateUserView : ContentPage
    {
        public CreateUserView()
        {
            InitializeComponent();
            BindingContext = new CreateUserViewModel(Navigation);
        }
    }
}