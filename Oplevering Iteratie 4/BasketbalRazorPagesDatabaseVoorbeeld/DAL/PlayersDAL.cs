using APPBasketbal.Models;
using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PlayersDAL : IPlayer
    {
        private List<Player> _players;
        public PlayersDAL()
        {
            _players = new List<Player>();
            string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
            string query = "SELECT * FROM speler";

            using (MySqlConnection sqlconnection = new MySqlConnection(connection))
            {
                using var cmd = new MySqlCommand(query, sqlconnection);
                sqlconnection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player pc = new Player();
                        pc.Id = Convert.ToInt32(reader["Id"]);
                        pc.FirstName = Convert.ToString(reader["FirstName"].ToString());
                        pc.LastName = Convert.ToString(reader["LastName"].ToString());
                        pc.ActiveTeam = Convert.ToString(reader["Active Team"].ToString());
                        pc.Games = Convert.ToInt32(reader["Games"].ToString());
                        pc.Points = Convert.ToDouble(reader["Points"].ToString());
                        pc.Rebounds = Convert.ToDouble(reader["Rebounds"].ToString());
                        pc.Assists = Convert.ToDouble(reader["Assists"].ToString());
                        pc.Blocks = Convert.ToDouble(reader["Blocks"].ToString());
                        _players.Add(pc);
                    }
                }
                sqlconnection.Close();
            }
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _players;
        }
    }
}
