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
    public class EditModel : PageModel
    {
        [BindProperty]
        public Player DisplayPlayer { get; set; }
        public IActionResult OnGet(int id)
        {
            PlayerCollection playerCollection = new PlayerCollection();
            try
            {
                DisplayPlayer = playerCollection.ReadPlayer(id);
            }
            catch (MySqlException e)
            {
                var code = e.ErrorCode;
                if (code == -2147467259)
                {
                    return RedirectToPage("/DatabaseConnectionError");
                }
                else
                {
                    return RedirectToPage("/Error");
                }
            }
            return Page();

        }
        public IActionResult OnPostAsync(int id)
        {
            PlayerCollection playerCollection = new PlayerCollection();
            try
            {
                playerCollection.UpdatePlayer(DisplayPlayer, id);
            }
            catch (MySqlException e)
            {
                var code = e.ErrorCode;
                if (code == -2147467259)
                {
                    return RedirectToPage("/DatabaseConnectionError");
                }
                else
                {
                    return RedirectToPage("/Error");
                }
            }
            return RedirectToPage("/Players");
        }
    }
}
