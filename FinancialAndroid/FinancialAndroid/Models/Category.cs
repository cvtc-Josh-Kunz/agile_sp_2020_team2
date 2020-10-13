using SQLite;

namespace FinancialAndroid.Models
{
    [Table("Category")]
    public class Category
    {
        [Column("id"), PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }
    }
}
