using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasketbalAPP.Pages
{
    public class TeamModel : PageModel
    {
        public IEnumerable<Team> GetTeams { get; set; }
        public void OnGet()
        {
            GetTeams = DisplayTeams();
        }

        public static List<Team> DisplayTeams()
        {
            TeamCollection teamCollection = new TeamCollection();
            teamCollection.GetAllTeams();
            List<Team> Listobj = teamCollection.GetTeams();
            return Listobj;
        }
    }
}
