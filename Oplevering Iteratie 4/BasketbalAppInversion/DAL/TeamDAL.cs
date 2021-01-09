using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using Logic.Interface.interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class TeamDAL : ITeamDal
    {
        public string Connection { get; set; }
        public TeamDAL()
        {
            Connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
        }

        public TeamDAL(string playerName, string teamName)
        {
            MySqlConnection mcon = new MySqlConnection(Connection);
            string cmdText = "INSERT INTO team Values('" + teamName + "','" + playerName + "')";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            mcon.Open();
            cmd.ExecuteNonQuery();
            mcon.Close();
        }


        public List<TeamDto> GetData()
        {
            List<TeamDto> data = new List<TeamDto>();
            string query = "SELECT * FROM team";
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            using var cmd = new MySqlCommand(query, sqlconnection);
            sqlconnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    data.Add(new TeamDto
                    {
                        IdTeam = Convert.ToInt32(reader["idTeam"].ToString()),
                        Name = Convert.ToString(reader["Name"].ToString()),
                        Owner = Convert.ToString(reader["Owner"].ToString())
                    });
                }
            }
            sqlconnection.Close();
            return data;
        }

        public List<PlayerDto> GetById(int id)
        {
            List<PlayerDto> data = new List<PlayerDto>();
            string query = "select speler.LastName, speler.FirstName from speler_team INNER JOIN speler ON speler.idPlayer = speler_team.idPlayer INNER JOIN team ON team.idTeam = speler_team.idTeam where speler_team.idTeam='" + id + "'";
            using MySqlConnection sqlconnection = new MySqlConnection(Connection);
            using var cmd = new MySqlCommand(query, sqlconnection);
            sqlconnection.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new PlayerDto
                {
                    LastName = Convert.ToString(reader["LastName"].ToString()),
                    FirstName = Convert.ToString(reader["FirstName"].ToString())
                });
            }
            sqlconnection.Close();
            return data;
        }
    }
}
