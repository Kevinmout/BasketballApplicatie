using BasketbalDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLogic
{
    public class PlayerCollection
    {
        private List<Player> players { get; }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public PlayerCollection()
        {
            players = new List<Player>();
        }
        public void PlayersDal()
        {
            BasketbalDAL.PlayersDal DAL = new BasketbalDAL.PlayersDal();
            foreach (PlayerDal spelerDaL in DAL.GetPlayers())
            {
                players.Add(new Player(
                    spelerDaL.LastName,
                    spelerDaL.FirstName,
                    spelerDaL.ActiveTeam,
                    spelerDaL.Games,
                    spelerDaL.Points,
                    spelerDaL.Assists,
                    spelerDaL.Rebounds,
                    spelerDaL.Blocks));
            }
        }
    }
}
