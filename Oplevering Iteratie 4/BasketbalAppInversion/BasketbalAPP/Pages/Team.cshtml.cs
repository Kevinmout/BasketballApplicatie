using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages
{
    public class TeamModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Team> GetTeams { get; set; }
        public IActionResult OnGet()
        {
            TeamCollection teamCollection = new TeamCollection();
            try
            {
                teamCollection.GetAllTeams();
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
                GetTeams = teamCollection.GetTeams();
            }
            return Page();
        }
    }
}
