using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketbalAPP.Models.PlayerTeam
{
    public class PlayerModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
