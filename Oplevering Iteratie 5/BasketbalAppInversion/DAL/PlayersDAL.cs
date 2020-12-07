using Logic;
using Logic.Interface.Dto_s;
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
        PlayerListDto playerListDto = new PlayerListDto();

        public PlayersDAL()
        {
            playerListDto.players = new List<PlayerDto>();
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
                        playerListDto.players.Add(new PlayerDto
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
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
                }
                sqlconnection.Close();
            }

        }

        public PlayerListDto GetPlayerList()
        {
            return playerListDto;
        }


        //public PlayerListDto GetPlayerList()
        //{
        //    return new PlayerListDto
        //    {
        //        //Name = "Los Angeles Lakers",
        //        players = new List<PlayerDto>
        //        {
        //            new PlayerDto
        //            {
        //                FirstName = "Lebron",
        //                Id = 6
        //            },
        //            new PlayerDto
        //            {
        //                FirstName = "Anthony",
        //                Id = 23
        //            }
        //        }
        //    };
        //}
    }
}


