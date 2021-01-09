using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BasketbalAPP.Pages.CRUD
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostAsync(Player player)
        {
            PlayerCollection playerCollection = new PlayerCollection();
            playerCollection.CreatePlayer(player);
            return RedirectToPage("/Players");
        }
    }
}
