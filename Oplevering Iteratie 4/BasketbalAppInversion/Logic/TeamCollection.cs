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
            foreach (var a in dal.GetById(id))
            {
                players.Add(new Player()
                {
                    LastName = a.LastName,
                    FirstName = a.FirstName
                });
            }

        }


        //CRUD
        public void CreateTeam(Team team)
        {
            teams.Add(team);
            ITeamDal dal = PlayerFactory.GetTeamDal();
            dal.Create(new TeamDto
            {
                Name = team.Name,
                Owner = team.Owner
            });
        }

        public Team ReadTeam(int id)
        {
            ITeamDal dal = PlayerFactory.GetTeamDal();
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
            ITeamDal dal = PlayerFactory.GetTeamDal();
            dal.Edit(new TeamDto
            {
                IdTeam = id,
                Name = team.Name
            });
        }

        public void DeleteTeam(Team team)
        {
            teams.Remove(team);
            ITeamDal dal = PlayerFactory.GetTeamDal();
            dal.Delete(team.IdTeam);
        }



        public void AddPlayerToTeam(Team team, Player player)
        {
            players.Add(player);
            ITeamDal dal = PlayerFactory.GetTeamDal();
            dal.AddPlayer(new TeamDto
            {
                IdTeam = team.IdTeam
            },new PlayerDto
            {
                IdPlayer = player.IdPlayer
            });
        }
    }
}
