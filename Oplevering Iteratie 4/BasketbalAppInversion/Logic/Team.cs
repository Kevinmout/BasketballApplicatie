﻿using APPBasketbal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Team
    {
        private List<Player> players;
        public string Name { get; set; }
        public List<Player> GetPlayers()
        {
            return players;
        }
        public Team()
        {
            players = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
