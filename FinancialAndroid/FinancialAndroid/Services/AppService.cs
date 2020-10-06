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
            //var map = GetMap(typeof(Category));

            string sql = "SELECT * FROM Category";

            //this might not work
            return await _database.FindWithQueryAsync<List<Category>>(sql);
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
                await Locator.CreateUserView.DisplayAlert("", e.ToString(), "");
                return false;
            }
        }

        #endregion
    }
}
