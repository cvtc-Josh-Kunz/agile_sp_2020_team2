using Xamarin.Forms;

namespace FinancialAndroid.ViewModels
{
    public class CategoryViewModel
    {
        public INavigation Navigation { get; set; }

        public CategoryViewModel(INavigation nav)
        {
            Navigation = nav;
        }
    }
}
