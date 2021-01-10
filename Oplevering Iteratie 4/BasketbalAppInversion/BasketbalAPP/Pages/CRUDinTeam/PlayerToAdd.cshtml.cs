using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasketbalAPP.Pages.CRUDinTeam
{
    public class PlayerToAddModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Player> DisplayPlayerinTeam { get; set; }
        public Player DisplayPlayer { get; set; }
        public Team GetTeam { get; set; }
        public void OnGet(int id)
        {
            TeamCollection teamCollection = new TeamCollection();
            PlayerCollection playerCollection = new PlayerCollection();
            GetTeam = teamCollection.ReadTeam(id);
            teamCollection.GetPlayers(id);
            DisplayPlayerinTeam = playerCollection.GetPlayersToAdd(id);
        }

        public IActionResult OnPostAsync(Player player, Team team)
        {
            TeamCollection teamCollection = new TeamCollection();
            teamCollection.AddPlayerToTeam(team, player);
            return RedirectToPage("/Team");
        }

    }
}

