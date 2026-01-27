using System;
using Microsoft.Data.Sqlite;

namespace DatabaseConnection
{
    public class InsertDataInTable
    {
        public static void InsertUsers()
        {
            using (SqliteConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                INSERT INTO Users (Name, MobileNumber, Address) VALUES
                ('Ravi','9876543210','Chennai'),
                ('Anita','9123456789','Bangalore'),
                ('Karan','9988776655','Mumbai');";

                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Users Inserted");
            }
        }

        public static void InsertProducts()
        {
            using (SqliteConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"
                INSERT INTO Products (ProductName, UserId) VALUES
                ('Mobile',1),
                ('Laptop',2),
                ('Headphone',3);";

                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Products Inserted");
            }
        }
    }
}
