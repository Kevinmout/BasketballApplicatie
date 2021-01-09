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

        public void OnGet(int id)
        {
            PlayerCollection playerCollection = new PlayerCollection();
            DisplayPlayer = playerCollection.ReadPlayer(id);
        }

    }
}

