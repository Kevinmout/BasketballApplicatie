using DAL;
using Logic;
using Logic.Interface.DTOs;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public static class PlayerFactory
    {
        public static IPlayerDal GetPlayerDal()
        {
            return new PlayersDAL();
        }

        public static ITeamDal GetTeamDal(string playerNameFromForm, string teamNameFromForm)
        {
            return new TeamDAL(playerNameFromForm, teamNameFromForm);
        }

    }
}
