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
    public class CreateModel : PageModel
    {
        public IActionResult OnPostAsync(Team team)
        {
            TeamCollection teamCollection = new TeamCollection();
            try
            {
                teamCollection.CreateTeam(team);
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
            return RedirectToPage("/Team");
        }
    }
}
