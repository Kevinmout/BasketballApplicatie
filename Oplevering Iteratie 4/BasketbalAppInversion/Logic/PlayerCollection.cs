using APPBasketbal.Models;
using Factory;
using Logic.Interface.Dto_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class PlayerCollection
    {
        private List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }

        public PlayerCollection()
        {
            players = new List<Player>();
        }

        public void getAllPlayers()
        {
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            foreach (var a in dal.GetPlayerList().players)
            {
                players.Add(new Player()
                {
                    Id = a.Id,
                    LastName = a.LastName,
                    FirstName = a.FirstName,
                    ActiveTeam = a.ActiveTeam,
                    Games = a.Games,
                    Points = a.Points,
                    Rebounds = a.Rebounds,
                    Assists = a.Assists,
                    Blocks = a.Blocks,
                });
            }
        }
    }
}
