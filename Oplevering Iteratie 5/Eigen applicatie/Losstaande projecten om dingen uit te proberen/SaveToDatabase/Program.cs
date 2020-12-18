using MySql.Data.MySqlClient;
using System;

namespace SaveToDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ja";
            string b = "nee";
            string connString = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";

            MySqlConnection mcon = new MySqlConnection(connString);


            string cmdText = "INSERT INTO team(TeamName,PlayerName)Values('" + a + "','" + b + "')";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            mcon.Open();
            cmd.ExecuteNonQuery();
            mcon.Close();
        }
    }
}
