using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbalDAL
{
    public class UsersDal
    {
        public List<UserDal> GetUsers()
        {
            List<UserDal> users = new List<UserDal>();
            string serverIp = "Localhost";
            string username = "root";
            string password = "root";
            string databaseName = "basketbal";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            string query = "SELECT * FROM user";

            var conn = new MySql.Data.MySqlClient.MySqlConnection(dbConnectionString);
            conn.Open();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new UserDal(
                    Convert.ToString(reader["Username"].ToString()),
                    Convert.ToString(reader["Password"].ToString())));
            }
            conn.Close();
            return users;

        }
    }
}
