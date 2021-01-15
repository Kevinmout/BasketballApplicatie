using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages.CRUDteam
{
    public class ReadModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Player> DisplayPlayerinTeam { get; set; }

        public IActionResult OnGet(int id)
        {
            Team team = new Team();
            try
            {
                team.GetPlayers(id);
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
                DisplayPlayerinTeam = team.GetPlayers();
            }
            return Page();
        }
    }
}
