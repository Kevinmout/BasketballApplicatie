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
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Team DisplayTeam { get; set; }
        public void OnGet(int id)
        {
            TeamCollection teamCollection = new TeamCollection();
            DisplayTeam = teamCollection.ReadTeam(id);
        }
        public IActionResult OnPostAsync(int id)
        {
            TeamCollection teamCollection = new TeamCollection();
            try
            {
                teamCollection.UpdateTeam(DisplayTeam, id);
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

            }
            return RedirectToPage("/Team");
        }



    }
}
