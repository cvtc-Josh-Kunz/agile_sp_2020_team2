using SQLite;

namespace FinancialAndroid.Models
{
    [Table("Users")]
    public class User
    {
        [Column("id"), PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}
