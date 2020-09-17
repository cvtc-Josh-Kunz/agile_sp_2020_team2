using System;
using GalaSoft.MvvmLight;

namespace FinancialAppp.ViewModels
{
    public class ExpenseViewModel : ViewModelBase
    {
        public int ExpenseId
        {
            get => _expenseId;
            set => Set(ref _expenseId, value);
        }
        private int _expenseId;

        public int CategoryId
        {
            get => _categoryId;
            set => Set(ref _categoryId, value);
        }
        private int _categoryId;

        public int UserId
        {
            get => _userId;
            set => Set(ref _userId, value);
        }
        private int _userId;

        public float Amount
        {
            get => _amount;
            set => Set(ref _amount, value);
        }
        private float _amount;

        public DateTime Date
        {
            get => _date;
            set => Set(ref _date, value);
        }
        private DateTime _date;
    }
}
