using System;
using System.IO;

using MySql.Data.MySqlClient;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverAddress = "server_address";
            string databaseName = "db_name";
            string username = "username";
            string password = "password";

            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}",
                                                serverAddress, databaseName, username, password);

            MySqlConnection connection = new MySqlConnection(connstring);
            connection.Open();

            string query = "SELECT * FROM customer";
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string columnZero = reader.GetString(0);
                string columnOne = reader.GetString(1);
                string columnTwo = reader.GetString(2);
                Console.WriteLine("{0, -3}{1, -15}{2, -15}", columnZero, columnOne, columnTwo);
            }
            connection.Close();
        }
    }
}
