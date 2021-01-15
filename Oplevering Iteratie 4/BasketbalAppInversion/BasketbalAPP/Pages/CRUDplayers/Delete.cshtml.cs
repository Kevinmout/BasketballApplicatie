using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APPBasketbal.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace BasketbalAPP.Pages.CRUD
{
    public class DeleteModel : PageModel
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
                DisplayPlayer = playerCollection.ReadPlayer(id);
                playerCollection.DeletePlayer(DisplayPlayer);
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
