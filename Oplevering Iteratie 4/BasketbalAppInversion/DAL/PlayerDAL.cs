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
        public PlayerDAL()
        {
            Connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
        }
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
                        Games = Convert.ToInt32(reader["Games"].ToString()),
                        Points = Convert.ToDouble(reader["Points"].ToString()),
                        Rebounds = Convert.ToDouble(reader["Rebounds"].ToString()),
                        Assists = Convert.ToDouble(reader["Assists"].ToString()),
                        Blocks = Convert.ToDouble(reader["Blocks"].ToString())
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
            string Insertdata = "Insert into speler Values(NULL, @lastname, @firstname, @activeteam, @games, @points, @rebounds, @assists,@blocks)";
            using MySqlCommand sqlCommand = new MySqlCommand(Insertdata, mySqlConnection);
            sqlCommand.Parameters.AddWithValue("@lastname", player.LastName);
            sqlCommand.Parameters.AddWithValue("@firstname", player.FirstName);
            sqlCommand.Parameters.AddWithValue("@activeteam", player.ActiveTeam);
            sqlCommand.Parameters.AddWithValue("@games", player.Games);
            sqlCommand.Parameters.AddWithValue("@points", player.Points);
            sqlCommand.Parameters.AddWithValue("@rebounds", player.Rebounds);
            sqlCommand.Parameters.AddWithValue("@assists", player.Assists);
            sqlCommand.Parameters.AddWithValue("@blocks", player.Blocks);
            mySqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public PlayerDto GetById(int id)
        {
            PlayerDto player = new PlayerDto();
            string query = "select * from speler where idPlayer = @idplayer";
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
                    player.Games = Convert.ToInt32(reader["Games"].ToString());
                    player.Points = Convert.ToDouble(reader["Points"].ToString());
                    player.Rebounds = Convert.ToDouble(reader["Rebounds"].ToString());
                    player.Assists = Convert.ToDouble(reader["Assists"].ToString());
                    player.Blocks = Convert.ToDouble(reader["Blocks"].ToString());
                }
            }
            sqlconnection.Close();
            return player;
        }

        public void Edit(PlayerDto player)
        {
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            string Updatequery = "Update speler set ActiveTeam = @activeteam, Games = @games where idPlayer = @idplayer";
            using MySqlCommand cmd = new MySqlCommand(Updatequery, sqlconnection);
            cmd.Parameters.AddWithValue("@activeteam", player.ActiveTeam);
            cmd.Parameters.AddWithValue("@games", player.Games);
            cmd.Parameters.Add("@idplayer", MySqlDbType.Int32);
            cmd.Parameters["@idplayer"].Value = player.IdPlayer;
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }








        public void Delete(int id)
        {

            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            string Updatequery = "Delet From speler where idPlayer = @idplayer";
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







        public List<PlayerDto> GetDataNotInTeam(int id)
        {
            List<PlayerDto> data = new List<PlayerDto>();
            string query = "select speler.* from speler where speler.LastName not in (select speler.LastName from speler_team INNER JOIN speler ON speler.idPlayer = speler_team.idPlayer INNER JOIN team ON team.idTeam = speler_team.idTeam where speler_team.idTeam = @idteam)";
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            using var cmd = new MySqlCommand(query, sqlconnection);
            cmd.Parameters.Add("@idteam", MySqlDbType.Int32);
            cmd.Parameters["@idteam"].Value = id;
            sqlconnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    data.Add(new PlayerDto
                    {
                        LastName = Convert.ToString(reader["LastName"].ToString()),
                        FirstName = Convert.ToString(reader["FirstName"].ToString())
                    });
                }
            }
            sqlconnection.Close();
            return data;
        }
    }
}
