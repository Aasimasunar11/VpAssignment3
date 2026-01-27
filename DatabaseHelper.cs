using Microsoft.Data.Sqlite;

namespace DatabaseConnection
{
    public class DatabaseHelper
    {
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection("Data Source=Ecommerce.db");
        }
    }
}
