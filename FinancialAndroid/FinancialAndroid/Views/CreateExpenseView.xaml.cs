using FinancialAndroid.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateExpenseView : ContentPage
    {
        public CreateExpenseView()
        {
            InitializeComponent();
            BindingContext = new CreateExpenseViewModel(Navigation);
        }
    }
}