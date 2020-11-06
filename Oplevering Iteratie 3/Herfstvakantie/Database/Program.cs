using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Namen = new List<string>();
            string serverIp = "Localhost";
            string username = "root";
            string password = "root";
            string databaseName = "basketbal";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            string query = "SELECT * FROM speler";

            var conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
            conn.Open();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            string Name = reader["Naam"].ToString();
            /*
            while (reader.Read())
            {
                Namen.Add(Convert.ToString(reader["Naam"].ToString()));
                //var someValue = reader["Naam"];
                
            }
            
            foreach(string item in Namen)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
