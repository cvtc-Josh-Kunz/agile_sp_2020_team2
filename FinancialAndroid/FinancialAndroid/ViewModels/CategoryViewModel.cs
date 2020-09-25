using GalaSoft.MvvmLight;

namespace FinancialAndroid.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }
        private int _id;

        public string CategoryName
        {
            get => _categoryName;
            set => Set(ref _categoryName, value);
        }
        private string _categoryName;
    }
}
