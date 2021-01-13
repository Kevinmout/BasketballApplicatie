using Logic;
using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PlayerDAL : IPlayerDal
    {

        public string Connection { get; set; }





        public List<PlayerDto> GetData()
        {
            List<PlayerDto> data = new List<PlayerDto>();
            string query = "SELECT * FROM speler";
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            using var cmd = new MySqlCommand(query, sqlconnection);
            sqlconnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    data.Add(new PlayerDto
                    {
                        IdPlayer = Convert.ToInt32(reader["idPlayer"].ToString()),
                        LastName = Convert.ToString(reader["LastName"].ToString()),
                        FirstName = Convert.ToString(reader["FirstName"].ToString()),
                        ActiveTeam = Convert.ToString(reader["ActiveTeam"].ToString()),
                    });
                }
            }
            sqlconnection.Close();
            return data;
        }


        //CRUD
        public void Create(PlayerDto player)
        {
            using MySqlConnection mySqlConnection = new MySqlConnection(Connection);
            string Insertdata = "Insert into speler Values(NULL, @lastname, @firstname, @activeteam)";
            using MySqlCommand sqlCommand = new MySqlCommand(Insertdata, mySqlConnection);
            sqlCommand.Parameters.AddWithValue("@lastname", player.LastName);
            sqlCommand.Parameters.AddWithValue("@firstname", player.FirstName);
            sqlCommand.Parameters.AddWithValue("@activeteam", player.ActiveTeam);
            mySqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }



        public void CreateInfo(PlayerDto player)
        {
            using MySqlConnection mySqlConnection = new MySqlConnection(Connection);
            string Insertdata = "Insert into speler_info Values((select max(last_insert_id()) as id from speler), @points, @rebounds, @assists, @blocks, @nationality)";
            using MySqlCommand sqlCommand = new MySqlCommand(Insertdata, mySqlConnection);
            sqlCommand.Parameters.AddWithValue("@points", player.Points);
            sqlCommand.Parameters.AddWithValue("@rebounds", player.Rebounds);
            sqlCommand.Parameters.AddWithValue("@assists", player.Assists);
            sqlCommand.Parameters.AddWithValue("@blocks", player.Blocks);
            sqlCommand.Parameters.AddWithValue("@nationality", player.Nationality);
            mySqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }







        public PlayerDto GetById(int id)
        {
            PlayerDto player = new PlayerDto();
            string query = "select speler_info.*, speler.LastName,speler.FirstName, speler.ActiveTeam From speler join speler_info where speler.idPlayer = @idplayer and speler_info.idPlayer = @idplayer";
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            using var cmd = new MySqlCommand(query, sqlconnection);
            cmd.Parameters.Add("@idplayer", MySqlDbType.Int32);
            cmd.Parameters["@idplayer"].Value = id;
            sqlconnection.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                {
                    player.IdPlayer = Convert.ToInt32(reader["idPlayer"].ToString());
                    player.LastName = Convert.ToString(reader["LastName"].ToString());
                    player.FirstName = Convert.ToString(reader["FirstName"].ToString());
                    player.ActiveTeam = Convert.ToString(reader["ActiveTeam"].ToString());
                    player.Points = Convert.ToInt32(reader["Points"].ToString());
                    player.Assists = Convert.ToInt32(reader["Assists"].ToString());
                    player.Rebounds = Convert.ToInt32(reader["Rebounds"].ToString());
                    player.Blocks = Convert.ToInt32(reader["Blocks"].ToString());
                    player.Nationality = Convert.ToString(reader["Nationality"].ToString());
                }
            }
            sqlconnection.Close();
            return player;
        }




        public void Edit(PlayerDto player)
        {
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            string Updatequery = "Update speler set ActiveTeam = @activeteam where idPlayer = @idplayer";
            using MySqlCommand cmd = new MySqlCommand(Updatequery, sqlconnection);
            cmd.Parameters.AddWithValue("@activeteam", player.ActiveTeam);
            cmd.Parameters.Add("@idplayer", MySqlDbType.Int32);
            cmd.Parameters["@idplayer"].Value = player.IdPlayer;
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }








        public void Delete(int id)
        {

            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            string Updatequery = "Delete speler, speler_info From speler join speler_info where speler.idPlayer = @idplayer and speler_info.idPlayer = @idplayer";
            using MySqlCommand cmd = new MySqlCommand(Updatequery, sqlconnection);
            cmd.Parameters.Add("@idplayer", MySqlDbType.Int32);
            cmd.Parameters["@idplayer"].Value = id;
            try
            {
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
        }








    }
}
