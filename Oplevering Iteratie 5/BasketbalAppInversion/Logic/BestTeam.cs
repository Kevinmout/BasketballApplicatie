using APPBasketbal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class BestTeam
    {
        private readonly List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }
        public BestTeam()
        {
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (players.Count <= 5)
            {
                players.Add(player);
            }
        }
    }
}
