using SQLite;
using System;

namespace FinancialAppp.Database.Tables
{
    [Table("Expenses")]
    public class Expense
    {
        [PrimaryKey, AutoIncrement, Column("expense_id")]
        public int ExpenseId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("amount")]
        public float Amount { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }
    }
}
