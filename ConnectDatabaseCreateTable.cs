using System;
using Microsoft.Data.Sqlite;

namespace DatabaseConnection
{
    public class ConnectDatabaseCreateTable
    {
        public static void CreateTables()
        {
            using (SqliteConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string userTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    MobileNumber TEXT,
                    Address TEXT
                );";

                string productTable = @"
                CREATE TABLE IF NOT EXISTS Products (
                    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT,
                    UserId INTEGER
                );";

                SqliteCommand cmd1 = new SqliteCommand(userTable, con);
                SqliteCommand cmd2 = new SqliteCommand(productTable, con);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Database & Tables Ready");
            }
        }
    }
}
