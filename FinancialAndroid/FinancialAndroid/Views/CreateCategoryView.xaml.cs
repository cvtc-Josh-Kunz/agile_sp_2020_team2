using FinancialAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCategoryView : ContentPage
    {
        public CreateCategoryView()
        {
            InitializeComponent();
            BindingContext = new CreateCategoryViewModel(Navigation);
        }
    }
}