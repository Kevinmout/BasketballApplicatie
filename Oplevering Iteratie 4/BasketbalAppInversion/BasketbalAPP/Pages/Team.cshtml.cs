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
        public List<Player> players { get; set; }
        public void OnGet()
        {

        }
    }
}
