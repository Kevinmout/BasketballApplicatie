using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLogic
{
    public class User
    {
        private List<Team> teams { get; set; }

        public User()
        {
            teams = new List<Team>();
        }

        public List<Team> GetTeams()
        {
            return teams;
        }

        public void CreateTeam(Player player)
        {
            Team newteam = new Team();
            teams.Add(newteam);
            newteam.AddPlayer(player);
        }

        public void RateTeam()
        {

        }
    }
}
