using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages
{
    public class PlayersModel : PageModel
    {
        public IEnumerable<Player> GetPlayers { get; set; }

        public IActionResult OnGet()
        {
            PlayerCollection playerCollection = new PlayerCollection();
            try
            {
                playerCollection.GetAllPlayers();
            }
            catch (MySqlException e)
            {
                var code = e.ErrorCode;
                if (code == -2147467259)
                {
                    return RedirectToPage("/DatabaseConnectionError");
                }
            }
            finally
            {
                GetPlayers = playerCollection.GetPlayers();
            }
            return Page();
        }
    }
}