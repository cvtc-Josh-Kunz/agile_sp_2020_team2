using System;
using System.IO;
using FinancialAppp.Database;

namespace FinancialAppp.Services
{
    public class AppServices
    {
        private static FinancialDatabase _database;

        public static FinancialDatabase Database =>
            _database ?? (_database = new FinancialDatabase(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "financial_db.db3")));

    }
}