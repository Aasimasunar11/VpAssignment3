using System;
using Microsoft.Data.Sqlite;

namespace DatabaseConnection
{
    public class ReadWriteData
    {
        public static void ReadUsers()
        {
            using (SqliteConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Users";
                SqliteCommand cmd = new SqliteCommand(query, con);

                SqliteDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("UserId | Name | Mobile | Address");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["UserId"]} | {reader["Name"]} | {reader["MobileNumber"]} | {reader["Address"]}"
                    );
                }
            }
        }
    }
}
