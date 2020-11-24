using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Logic;
using APPBasketbal.Models;

namespace APPBasketbal.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        //public IEnumerable<PlayerClass> GetPlayers { get; set; }
        //public IEnumerable<TeamClass> GetTeam { get; set; }

        private readonly IPlayer iplayer;

        public IEnumerable<Player> Players { get; set; }

        public IndexModel(IPlayer iplayer)
        {
            this.iplayer = iplayer;
        }

        public void OnGet()
        {
            Players = iplayer.GetPlayers();
        }



        //public static List<PlayerClass> DisplayPlayer()
        //{
        //    List<PlayerClass> Listobj = new List<PlayerClass>();
        //    string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
        //    string query = "SELECT * FROM speler";

        //    using (MySqlConnection sqlconnection = new MySqlConnection(connection))
        //    {
        //        using var cmd = new MySqlCommand(query, sqlconnection);
        //        sqlconnection.Open();
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                PlayerClass pc = new PlayerClass();
        //                pc.Id = Convert.ToInt32(reader["Id"]);
        //                pc.FirstName = Convert.ToString(reader["FirstName"].ToString());
        //                pc.LastName = Convert.ToString(reader["LastName"].ToString());
        //                pc.ActiveTeam = Convert.ToString(reader["Active Team"].ToString());
        //                pc.Games = Convert.ToInt32(reader["Games"].ToString());
        //                pc.Points = Convert.ToDouble(reader["Points"].ToString());
        //                pc.Rebounds = Convert.ToDouble(reader["Rebounds"].ToString());
        //                pc.Assists = Convert.ToDouble(reader["Assists"].ToString());
        //                pc.Blocks = Convert.ToDouble(reader["Blocks"].ToString());
        //                Listobj.Add(pc);
        //            }
        //        }
        //        sqlconnection.Close();
        //    }
        //    return Listobj;
        //}


    }
}
