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
        public string PlayerName { get; set; }
        public string PlayerNamePost { get; set; }
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            PlayerNamePost = Request.Form["PlayerName"];
            Team team = new Team(PlayerNamePost);
            team.PostTeam();
        }
    }
}
