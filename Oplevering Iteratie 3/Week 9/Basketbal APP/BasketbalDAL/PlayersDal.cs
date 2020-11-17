using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BasketbalDAL
{
    public class PlayersDal
    {
        
        public List<PlayerDal> GetPlayers()
        {
            List<PlayerDal> spelers = new List<PlayerDal>();
            string serverIp = "Localhost";
            string username = "root";
            string password = "root";
            string databaseName = "basketbal";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            string query = "SELECT * FROM speler";

            var conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spelers.Add(new PlayerDal( 
                    Convert.ToString(reader["LastName"].ToString()), 
                    Convert.ToString(reader["FirstName"].ToString()),
                    Convert.ToString(reader["Active Team"].ToString()),
                    Convert.ToInt32(reader["Games"].ToString()),
                    Convert.ToDouble(reader["Points"].ToString()),
                    Convert.ToDouble(reader["Rebounds"].ToString()),
                    Convert.ToDouble(reader["Assists"].ToString()),
                    Convert.ToDouble(reader["Blocks"].ToString())));
            }
            conn.Close();
            return spelers;
            
        }
    }
}

