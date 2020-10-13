using FinancialAndroid.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialAndroid.Services
{
    public class AppService
    {
        private readonly SQLiteAsyncConnection _database;

        public AppService()
        {
            _database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Financial_db.db3"));
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Expense>().Wait();
            _database.CreateTableAsync<Category>().Wait();
        }

        public async Task<User> GetUserByCredentials(string username, string password)
        {
            //var map = GetMap(typeof(User));

            string sql = $"SELECT * FROM Users WHERE username = '{username}' AND password = '{password}'";

            var user = await _database.FindWithQueryAsync<User>(sql);

            return user;
        }

        public async Task<List<Category>> GetCategories()
        {
            var catTable = _database.Table<Category>();

            return await catTable.ToListAsync();
        }

        public TableMapping GetMap(Type t)
        {
            return _database.TableMappings.Where(x => x.MappedType == t).FirstOrDefault();
        }

        #region Create User
        public async Task<bool> TryCreateUser(string username, string password)
        {
            try
            {
                var exists = (await GetUserByCredentials(username, password)) != null;

                if (!exists)
                {
                    var user = new User()
                    {
                        Username = username,
                        Password = password
                    };

                    await _database.InsertAsync(user);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
        #endregion

        #region Create Category
        public async Task<bool> TryCreateCategory(string categoryName)
        {
            try
            {
                var newCategory = new Category()
                {
                    CategoryName = categoryName
                };

                await _database.InsertAsync(newCategory);

                return true;
            }
            catch (Exception e)
            {
                await Locator.CreateCategoryView.DisplayAlert("error", e.ToString(), "ok");
                return false;
            }
        }
        #endregion

        #region Create Expense
        public async Task<bool> CreateExpense(Expense e)
        {
            try
            {
                await _database.InsertAsync(e);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
