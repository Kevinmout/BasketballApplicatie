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
        public string TeamNamePost { get; set; }
        private List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }
        public void OnGet()
        {
            PlayerCollection playerCollection = new PlayerCollection();
            playerCollection.getAllPlayers();
            players = playerCollection.GetPlayers();
        }

        public void OnPost()
        {
            PlayerNamePost = Request.Form["PlayerName"];
            TeamNamePost = Request.Form["TeamName"];
            Team team = new Team(PlayerNamePost, TeamNamePost);
            team.PostTeam();
        }
    }
}
