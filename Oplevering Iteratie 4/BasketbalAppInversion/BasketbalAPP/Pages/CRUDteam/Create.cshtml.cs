using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasketbalAPP.Pages.CRUDteam
{
    public class CreateModel : PageModel
    {
        public IActionResult OnPostAsync(Team team)
        {
            TeamCollection teamCollection = new TeamCollection();
            teamCollection.CreateTeam(team);
            return RedirectToPage("/Team");
        }
    }
}
