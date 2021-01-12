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
        public IEnumerable<Player> GetPlayers { get; set; }
        public void OnGet()
        {
            GetPlayers = DisplayPlayers();
        }

        public static List<Player> DisplayPlayers()
        {
            PlayerCollection playerCollection = new PlayerCollection();
            playerCollection.GetAllPlayers();
            List<Player> Listobj = playerCollection.GetPlayers();
            return Listobj;
        }
    }
}