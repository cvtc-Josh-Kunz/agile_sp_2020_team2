using FinancialAppp.Database.Tables;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialAppp.Database
{
    public class FinancialDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public FinancialDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Category>().Wait();
            _database.CreateTableAsync<Expense>().Wait();
        }

        public async Task<User> GetUserAsync(string username, string password) => await _database.Table<User>()
            .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefaultAsync();

        public async Task<User> GetUserAsync(int id) =>
            await _database.Table<User>().Where(x => x.UserId == id).FirstOrDefaultAsync();

        public async Task<bool> CreateNewUser(string username, string password)
        {
            var user = new User
            {
                UserId = 0,
                Username = username,
                Password = password

            };

            var rowsChanged = await SaveUserAsync(user);

            return rowsChanged == 1;
        }

        public async Task<int> SaveUserAsync(User user) =>
            user.UserId != 0 ? await _database.UpdateAsync(user) : await _database.InsertAsync(user);

        public async Task<int> DeleteUserAsync(User user) =>
            await _database.DeleteAsync(user);

        public async Task<List<Expense>> GetUserExpenses(User user) =>
            (await _database.Table<Expense>().ToListAsync()).Where(x => x.UserId == user.UserId).ToList();

        public async Task<Category> GetCategoryAsync(int id) =>
            await _database.Table<Category>().FirstOrDefaultAsync(x => x.CategoryId == id);

        public async Task<int> DeleteCategoryAsync(Category category, User user)
        {
            //delete the category from the table.
            await _database.DeleteAsync(category);

            //remove the category ID from the expenses that have it and set it to the default category of 0
            var relatedExpenses = (await _database.Table<Expense>().ToListAsync()).Where(x =>
                x.UserId == user.UserId && x.CategoryId == category.CategoryId).ToList();

            //change the category in the expenses table
            foreach (var exp in relatedExpenses)
            {
                exp.CategoryId = 0;
            }

            return await _database.UpdateAllAsync(relatedExpenses);
        }
    }
}
