using APPBasketbal.Models;
using Factory;
using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
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

        public void GetAllPlayers()
        {
            IPlayerDal dal = PlayerFactory.GetPlayerDal();

            foreach (var a in dal.GetData())
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


        public Player ReadPlayer(Player player)
        {
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            PlayerDto playerDTO = dal.GetById(player.Id);
            return new Player()
            {
                Id = playerDTO.Id,
                LastName = playerDTO.LastName,
                FirstName = playerDTO.FirstName,
                ActiveTeam = playerDTO.ActiveTeam,
                Games = playerDTO.Games,
                Points = playerDTO.Points,
                Rebounds = playerDTO.Rebounds,
                Assists = playerDTO.Assists,
                Blocks = playerDTO.Blocks
            };
        }


        public void DeletePlayer(Player player)
        {
            players.Remove(player);
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            dal.Delete(player.Id);
        }



        public void AddPlayer(Player player)
        {
            players.Add(player);
            IPlayerDal dal = PlayerFactory.GetPlayerDal();

            dal.Create(new Interface.DTOs.PlayerDto
            {
                LastName = player.LastName,
                FirstName = player.FirstName,
                ActiveTeam = player.ActiveTeam,
                Games = player.Games,
                Points = player.Points,
                Rebounds = player.Rebounds,
                Assists = player.Assists,
                Blocks = player.Blocks,
            });
        }
    }
}
