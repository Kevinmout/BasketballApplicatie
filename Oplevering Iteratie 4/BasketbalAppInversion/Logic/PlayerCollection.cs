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
                    IdPlayer = a.IdPlayer,
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


        public List<Player> GetPlayersToAdd(int id)
        {
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            foreach (var a in dal.GetDataNotInTeam(id))
            {
                players.Add(new Player()
                {
                    IdPlayer = a.IdPlayer,
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
            return players;
        }



        //CRUD
        public void CreatePlayer(Player player)
        {
            players.Add(player);
            IPlayerDal dal = PlayerFactory.GetPlayerDal();

            dal.Create(new PlayerDto
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


        public Player ReadPlayer(int id)
        {
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            PlayerDto playerDTO = dal.GetById(id);
            return new Player()
            {
                IdPlayer = playerDTO.IdPlayer,
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


        public void UpdatePlayer(Player player, int id)
        {
            players.Add(player);
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            dal.Edit(new PlayerDto
            {
                IdPlayer = id,
                ActiveTeam = player.ActiveTeam,
                Games = player.Games,
            });
            
        }


        public void DeletePlayer(Player player)
        {
            players.Remove(player);
            IPlayerDal dal = PlayerFactory.GetPlayerDal();
            dal.Delete(player.IdPlayer);
        }




    }
}
