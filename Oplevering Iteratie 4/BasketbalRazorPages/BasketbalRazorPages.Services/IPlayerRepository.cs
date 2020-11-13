using BasketbalRazorPages.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BasketbalRazorPages.Services
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers();
    }
}