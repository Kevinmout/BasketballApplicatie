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
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Player DisplayPlayer { get; set; }



        //public static List<Player> DisplayPlayers()
        //{
        //    List<Player> Listobj = new List<Player>();
        //    PlayerCollection playerCollection = new PlayerCollection();
        //    playerCollection.Read();
        //    Listobj = playerCollection.GetPlayers();
        //    return Listobj;
        //}


        public void OnGet(Player player)
        {
            PlayerCollection playerCollection = new PlayerCollection();
            DisplayPlayer = playerCollection.ReadPlayer(player);
        }
    }
}

