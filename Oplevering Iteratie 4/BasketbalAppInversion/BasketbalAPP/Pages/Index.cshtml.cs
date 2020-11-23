using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BasketbalAPP.Pages
{
    public class IndexModel : PageModel
    {
        public List<Player> Players { get; set; }
        public void OnGet()
        {
            PlayerCollection playerCollection = new PlayerCollection();
            playerCollection.getPlayerFromDal();
            Players = playerCollection.GetPlayers();
        }
    }
}
