using FinancialAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryView : ContentPage
    {
        public CategoryView()
        {
            InitializeComponent();
            //BindingContext = new CategoryViewModel();
            
        }
    }
}