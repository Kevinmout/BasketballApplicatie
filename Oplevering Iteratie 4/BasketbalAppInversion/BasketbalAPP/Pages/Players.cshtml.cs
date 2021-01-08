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
    public class PlayersModel : PageModel
    {
        public IEnumerable<Player> Getplayer { get; set; }
        public void OnGet()
        {
            Getplayer = DisplayPlayers();
        }

        public static List<Player> DisplayPlayers()
        {
            List<Player> Listobj = new List<Player>();
            PlayerCollection playerCollection = new PlayerCollection();
            playerCollection.getAllPlayers();
            Listobj = playerCollection.GetPlayers();
            return Listobj;
        }
    }
}
