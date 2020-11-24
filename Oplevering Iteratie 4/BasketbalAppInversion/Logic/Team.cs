using APPBasketbal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> players { get; set; }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
