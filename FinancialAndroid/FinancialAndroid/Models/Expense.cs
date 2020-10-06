using SQLite;
using System;

namespace FinancialAndroid.Models
{
    [Table("Expenses")]
    public class Expense
    {
        [Column("id"), PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("amount")]
        public float Amount { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }
    }
}
