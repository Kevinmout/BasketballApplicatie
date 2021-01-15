using APPBasketbal.Models;
using Factory;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APPBasketbal.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }


        List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }

        public Team()
        {
            players = new List<Player>();
        }

        public void GetPlayers(int id)
        {
            ITeamDal dal = PlayerFactory.GetTeamDal();
            foreach (var a in dal.GetById(id))
            {
                players.Add(new Player()
                {
                    LastName = a.LastName,
                    FirstName = a.FirstName
                });
            }

        }
    }
}
