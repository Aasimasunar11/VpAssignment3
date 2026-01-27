using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectDatabaseCreateTable.CreateTables();

            InsertDataInTable.InsertUsers();
            InsertDataInTable.InsertProducts();

            ReadWriteData.ReadUsers();

            Console.WriteLine("Program Completed Successfully");
            Console.ReadLine();
        }
    }
}
