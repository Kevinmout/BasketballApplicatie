using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class User
    {
        private string userName;
        private string passWord;
        private List<Team> teams;
        private List<BestTeam> bestTeam;
        public string UserName 
        {
             get {return userName; }
             set { userName = UserName; } 
        }
        public string PassWord 
        {
            get { return passWord; }
            set { passWord = PassWord; }
        }

        public List<Team> GetTeams()
        {
            return teams;
        }

        public List<BestTeam> GetBestTeam()
        {
            return bestTeam;
        }

        public User()
        {
            teams = new List<Team>();
            bestTeam = new List<BestTeam>();
        }

        public void AddTeam(Team team)
        {
            this.teams.Add(team);
        }

        public void GiveBestTeam(BestTeam bestTeam)
        {
            this.bestTeam.Add(bestTeam);
        }
    }
}
