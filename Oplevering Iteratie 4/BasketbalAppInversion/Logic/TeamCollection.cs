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
        private List<Team> teams;
        public List<Team> GetTeams()
        {
            return teams;
        }

        public TeamCollection()
        {
            teams = new List<Team>();
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

        public Player GetPlayer(int id)
        {
            ITeamDal dal = PlayerFactory.GetTeamDal();

            PlayerDto playerDto = dal.GetById(id);
            return new Player()
            {
                LastName = playerDto.LastName,
                FirstName = playerDto.FirstName
            };

        }
    }
}
