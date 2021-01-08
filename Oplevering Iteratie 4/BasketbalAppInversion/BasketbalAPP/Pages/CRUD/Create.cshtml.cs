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
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostAsync(Player playerinsert)
        {
            string connection = "server=Localhost;user id=root;password =root;database=basketbal;allowuservariables=True;persistsecurityinfo=True";
            using (MySqlConnection mySqlConnection = new MySqlConnection(connection))
            {
                string Insertdata = "Insert into speler Values(NULL, '" + playerinsert.LastName + "','" + playerinsert.FirstName + "','" + playerinsert.ActiveTeam + "','" + playerinsert.Games + "','" + playerinsert.Points + "','" + playerinsert.Rebounds + "','" + playerinsert.Assists + "','" + playerinsert.Blocks + "')";
                using (MySqlCommand sqlCommand = new MySqlCommand(Insertdata, mySqlConnection))
                {
                    mySqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
            }
            return RedirectToPage("/Players");
        }
    }
}
