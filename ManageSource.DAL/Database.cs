using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSource.DAL
{
    internal class Database
    {
        private string connectionString = "Data Source=database.db;Version=3;";

        public void Initialize()
        {
            //using (var connection = new SQLiteConnection(connectionString))
            //{
            //    connection.Open();
            //    string sql = "CREATE TABLE IF NOT EXISTS Repositories (Id INTEGER PRIMARY KEY, Name TEXT, Path TEXT)";
            //    SQLiteCommand command = new SQLiteCommand(sql, connection);
            //    command.ExecuteNonQuery();
            //}
        }
    }
}
