using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasketbalAPP.Pages.CRUDteam
{
    public class ReadModel : PageModel
    {
        [BindProperty]
        public Player DisplayPlayerinTeam { get; set; }
        public Team Team { get; set; }

        public void OnGet(int id)
        {
            TeamCollection teamCollection = new TeamCollection();
            DisplayPlayerinTeam = teamCollection.GetPlayer(id);
        }
    }
}
