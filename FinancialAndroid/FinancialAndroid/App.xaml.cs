using FinancialAndroid.Views;
using Xamarin.Forms;

namespace FinancialAndroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Locator.LoginView = new LoginView();
            Locator.ExpensesView = new ExpensesView();
            Locator.CategoryView = new CategoryView();
            Locator.CreateUserView = new CreateUserView();

            MainPage = new NavigationPage(Locator.LoginView);
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
    }
}
