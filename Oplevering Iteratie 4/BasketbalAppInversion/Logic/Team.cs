using APPBasketbal.Models;
using Factory;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }
    }
}
