using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinancialAndroid.ViewModels
{
    public class ExpenseViewModel : ViewModelBase
    {
        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }
        private int _id;

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
