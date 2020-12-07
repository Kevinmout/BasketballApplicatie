using APPBasketbal.Models;
using Factory;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Team
    {
        public string PlayerName { get; set; }
        public string PlayerNameFromForm { get; set; }
        public string TeamName { get; set; }
        public Team(string playerName, string teamName)
        {
            PlayerNameFromForm = playerName;
            TeamName = teamName;
        }
        public void GetTeam()
        {
            //ITeamDal dal = PlayerFactory.GetTeamDal();
            //PlayerName = dal.PlayerName;
        }
        public void PostTeam()
        {
            ITeamDal dal = PlayerFactory.GetTeamDal(PlayerNameFromForm, TeamName);
        }
    }
}
