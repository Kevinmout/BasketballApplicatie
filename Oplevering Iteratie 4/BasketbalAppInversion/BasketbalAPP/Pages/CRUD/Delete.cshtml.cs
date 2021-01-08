using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages.CRUD
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Player DisplayPlayer { get; set; }
        public void OnGet(int id)
        {
            Player player = new Player();
            string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
            string query = "select * from speler where Id ='" + id + "'";
            using (MySqlConnection sqlconnection = new MySqlConnection(connection))
            {
                using var cmd = new MySqlCommand(query, sqlconnection);
                sqlconnection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        player.Id = Convert.ToInt32(reader["Id"].ToString());
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
                DisplayPlayer = player;
            }
        }

        public IActionResult OnPostAsync(int id)
        {
            string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
            using (MySqlConnection sqlconnection = new MySqlConnection(connection))
            {
                string Updatequery = "Delete From speler where Id=" + id;
                using (MySqlCommand sqlCommand = new MySqlCommand(Updatequery, sqlconnection))
                {
                    sqlconnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlconnection.Close();
                }
            }
            return RedirectToPage("/Players");

        }
    }
}
