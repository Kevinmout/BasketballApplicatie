using Logic.Interface.interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class TeamDAL : ITeamDal
    {
        public string PlayerName { get; set; }
        public TeamDAL(string playerName, string teamName)
        {
            string connString = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";

            MySqlConnection mcon = new MySqlConnection(connString);


            string cmdText = "INSERT INTO team(TeamName,PlayerName)Values('" + teamName + "','" + playerName + "')";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            mcon.Open();
            cmd.ExecuteNonQuery();
            mcon.Close();
        }
    }
}
