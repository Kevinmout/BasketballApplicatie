using APPBasketbal.Models;
using Factory;
using Logic.Interface.DTOs;
using Logic.Interface.Dto_s;
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

        private readonly ITeamDal dal;

        public TeamCollection()
        {
            teams = new List<Team>();
            dal = PlayerFactory.GetTeamDal();

        }
        public void GetAllTeams()
        {
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




        //CRUD
        public void CreateTeam(Team team)
        {
            teams.Add(team);
            dal.Create(new TeamDto
            {
                Name = team.Name,
                Owner = team.Owner
            });
        }

        public Team ReadTeam(int id)
        {
            TeamDto teamDto = dal.GetTeamById(id);
            return new Team()
            {
                IdTeam =teamDto.IdTeam,
                Name = teamDto.Name,
                Owner = teamDto.Owner
            };
        }

        public void UpdateTeam(Team team, int id)
        {
            dal.Edit(new TeamDto
            {
                IdTeam = id,
                Name = team.Name
            });
        }

        public void DeleteTeam(Team team)
        {
            teams.Remove(team);
            dal.Delete(team.IdTeam);
        }

    }
}
