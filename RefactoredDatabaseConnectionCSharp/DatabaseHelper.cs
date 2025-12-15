using System;
using MySql.Data.MySqlClient;

namespace DatabaseConnection
{
    public static class DatabaseHelper
    {
        // Connection without database (for CREATE DATABASE, etc.)
        private static readonly string ServerConnectionString =
            "server=localhost;user=root;password=;port=3306;";

        // Connection WITH database (this MUST exist
        private static readonly string DatabaseConnectionString =
            "server=localhost;user=root;password=;database=testdb;port=3306;";

        public static MySqlConnection GetServerConnection()
        {
            return new MySqlConnection(ServerConnectionString);
        }

        public static MySqlConnection GetDatabaseConnection()
        {
            return new MySqlConnection(DatabaseConnectionString);
        }

        public static void ExecuteNonQuery(
            MySqlConnection connection,
            string query,
            Action<MySqlCommand>? parameters = null)
        {
            using MySqlCommand command = new MySqlCommand(query, connection);
            parameters?.Invoke(command);
            command.ExecuteNonQuery();
        }
    }
}
   