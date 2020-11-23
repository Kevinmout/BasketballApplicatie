using Logic;
using Logic.Interface.DTOs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class PlayersDAL : IPlayerDal
    {
        PlayerDto playerDto = new PlayerDto();
        private List<PlayerDto> players;
        public PlayersDAL()
        {
            players = new List<PlayerDto>();
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
                        
                        playerDto.Id = Convert.ToInt32(reader["Id"]);
                        playerDto.FirstName = Convert.ToString(reader["FirstName"].ToString());
                        players.Add(playerDto);
                    }
                }
                sqlconnection.Close();
            }

        }

        public PlayerDto GetPlayer()
        {
            return playerDto;
        }
    }
}

