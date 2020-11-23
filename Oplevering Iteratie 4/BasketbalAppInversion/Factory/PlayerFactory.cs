using DAL;
using Logic;
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
    }
}
