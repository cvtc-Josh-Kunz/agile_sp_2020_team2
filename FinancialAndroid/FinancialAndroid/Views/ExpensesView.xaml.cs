using FinancialAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesView : ContentPage
    {
        public ExpensesView()
        {
            InitializeComponent();
            BindingContext = new ExpensesViewModel(Navigation);
        }
    }
}