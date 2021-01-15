using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using APPBasketbal.Models;
using Logic;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages.PlayersToAdd
{
	public class ControllerModel : PageModel
	{
        [BindProperty]
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IActionResult OnGet()
        {
            PlayerCollection playerCollection = new PlayerCollection();
            TeamCollection teamCollection = new TeamCollection();
            try
            {
                playerCollection.GetAllPlayers();
                teamCollection.GetAllTeams();
            }
            catch (MySqlException e)
            {
                var code = e.ErrorCode;
                if (code == -2147467259)
                {
                    return RedirectToPage("/DatabaseConnectionError");
                }
                else
                {
                    return RedirectToPage("/Error");
                }

            }
            finally
            {
                Players = playerCollection.GetPlayers();
                Teams = teamCollection.GetTeams();
            }
            return Page();

        }

    }
}
