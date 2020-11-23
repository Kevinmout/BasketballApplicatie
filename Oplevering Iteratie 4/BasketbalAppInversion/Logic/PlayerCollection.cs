using APPBasketbal.Models;
using Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class PlayerCollection
    {
        private List<Player> players { get; set; }
        public List<Player> GetPlayers()
        {
            return players;
        }

        public void getPlayerFromDal()
        {
            players = new List<Player>();
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            players.Add(new Player(dal.GetPlayer()));
        }
    }
}
