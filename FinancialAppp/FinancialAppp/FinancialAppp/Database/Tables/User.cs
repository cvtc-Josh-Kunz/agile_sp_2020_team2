using SQLite;

namespace FinancialAppp.Database.Tables
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("user_id")]
        public int UserId { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }
    }
}
