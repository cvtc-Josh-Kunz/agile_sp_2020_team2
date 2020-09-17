using SQLite;

namespace FinancialAppp.Database.Tables
{
    [Table("Categories")]
    public class Category
    {
        [PrimaryKey, AutoIncrement, Column("category_id")]
        public int CategoryId { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }
    }
}
