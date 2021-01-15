using APPBasketbal.Models;
using Factory;
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

        private readonly IPlayerDal dal;

        public PlayerCollection()
        {
            dal = PlayerFactory.GetPlayerDal();
            players = new List<Player>();
        }

        public void GetAllPlayers()
        {

            foreach (var a in dal.GetData())
            {
                players.Add(new Player()
                {
                    IdPlayer = a.IdPlayer,
                    LastName = a.LastName,
                    FirstName = a.FirstName,
                    ActiveTeam = a.ActiveTeam
                });
            }
        }


        public PlayerInfo ReadInfo(int id)
        {
            PlayerDto info = dal.GetById(id);
            return new PlayerInfo()
            {
                IdPlayer = info.IdPlayer,
                Points = info.Points,
                Rebounds = info.Rebounds,
                Assists = info.Assists,
                Blocks = info.Blocks,
                Nationality = info.Nationality
            };
        }






        //CRUD

        //Create
        public void CreatePlayer(Player player)
        {
            players.Add(player);

            dal.Create(new PlayerDto
            {
                LastName = player.LastName,
                FirstName = player.FirstName,
                ActiveTeam = player.ActiveTeam
            });
            dal.CreateInfo(new PlayerDto
            {
                Points = player.Points,
                Assists = player.Assists,
                Rebounds = player.Rebounds,
                Blocks = player.Blocks,
                Nationality = player.Nationality
            });
        }

        //Read
        public Player ReadPlayer(int id)
        {
            PlayerDto playerDTO = dal.GetById(id);
            return new Player()
            {
                IdPlayer = playerDTO.IdPlayer,
                LastName = playerDTO.LastName,
                FirstName = playerDTO.FirstName,
                ActiveTeam = playerDTO.ActiveTeam
            };
        }

        //Update
        public void UpdatePlayer(Player player, int id)
        {
            players.Add(player);
            dal.Edit(new PlayerDto
            {
                IdPlayer = id,
                ActiveTeam = player.ActiveTeam
            });
            
        }

        //Delete
        public void DeletePlayer(Player player)
        {
            players.Remove(player);
            dal.Delete(player.IdPlayer);
        }




    }
}
