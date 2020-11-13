using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasketbalRazorPages.Models;
using BasketbalRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasketball.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly IPlayerRepository playerRepository;

        public IEnumerable<Player> Players { get; set; }

        public IndexModel(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public void OnGet()
        {
            Players = playerRepository.GetPlayers();
        }
    }
}
