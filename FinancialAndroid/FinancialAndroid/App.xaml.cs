using FinancialAndroid.Factory;
using FinancialAndroid.Services;
using FinancialAndroid.Views;
using System.Runtime.InteropServices;
using Xamarin.Forms;

namespace FinancialAndroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<AppService>();
            DependencyService.Register<AppFactory>();

            Locator.LoginView = new LoginView();
            Locator.ExpensesView = new ExpensesView();
            Locator.CategoryView = new CategoryView();
            Locator.CreateUserView = new CreateUserView();
            Locator.CreateCategoryView = new CreateCategoryView();
            Locator.CreateExpenseView = new CreateExpenseView();

            MainPage = new NavigationPage(Locator.LoginView);

            //Test();
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

        public async void Test()
        {
            var list = await DependencyService.Get<AppService>().GetCategories();

            var v = (list == null).ToString();

            await Locator.LoginView.DisplayAlert(v, "test", "ok");
        }
    }
}
