using APPBasketbal.Models;
using Factory;
using Logic.Interface.DTOs;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class TeamCollection
    {
        List<Player> players;
        public List<Player> GetPlayers()
        {
            return players;
        }
        private List<Team> teams;
        public List<Team> GetTeams()
        {
            return teams;
        }

        public TeamCollection()
        {
            teams = new List<Team>();
            players = new List<Player>();
        }
        public void GetAllTeams()
        {
            ITeamDal dal = PlayerFactory.GetTeamDal();
            foreach (var a in dal.GetData())
            {
                teams.Add(new Team()
                {
                    IdTeam = a.IdTeam,
                    Name = a.Name,
                    Owner = a.Owner
                });
            }
        }

        public void GetPlayers(int id)
        {
            ITeamDal dal = PlayerFactory.GetTeamDal();
            Team team = new Team();
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
