using Auto.Logic.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Player.Dal
{
    public class PlayersDal : IPlayer
    {
        public List<Auto.Logic.Player> GetPlayers()
        {
            List<Auto.Logic.Player> spelers = new List<Auto.Logic.Player>();
            string serverIp = "Localhost";
            string username = "root";
            string password = "root";
            string databaseName = "basketbal";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            string query = "SELECT * FROM speler";

            var conn = new MySqlConnection(dbConnectionString);
            conn.Open();

            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                spelers.Add(new Auto.Logic.Player
                {
                    LastName = Convert.ToString(reader["LastName"].ToString()),
                    FirstName = Convert.ToString(reader["FirstName"].ToString()),
                    ActiveTeam = Convert.ToString(reader["Active Team"].ToString()),
                    Games = Convert.ToInt32(reader["Games"].ToString()),
                    Points = Convert.ToDouble(reader["Points"].ToString()),
                    Rebounds = Convert.ToDouble(reader["Rebounds"].ToString()),
                    Assists = Convert.ToDouble(reader["Assists"].ToString()),
                    Blocks = Convert.ToDouble(reader["Blocks"].ToString())
                });
            }
            conn.Close();
            return spelers;
        }
    }
}
