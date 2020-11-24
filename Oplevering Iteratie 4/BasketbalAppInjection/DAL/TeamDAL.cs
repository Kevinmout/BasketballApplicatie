using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class TeamDAL
    {
        public TeamDAL()
        {
            string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
            string query = "SELECT * FROM team";

            using (MySqlConnection sqlconnection = new MySqlConnection(connection))
            {
                using var cmd = new MySqlCommand(query, sqlconnection);
                sqlconnection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Team team = new Team();
                        team.IdTeam = Convert.ToString(reader["IdTeam"]);
                        team.TeamName = Convert.ToString(reader["TeamName"].ToString());
                    }
                }
                sqlconnection.Close();
            }
        }
    }
}
