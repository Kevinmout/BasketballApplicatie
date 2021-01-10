using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            teamCollection.UpdateTeam(DisplayTeam, id);
            return RedirectToPage("/Team");
        }
    }
}
