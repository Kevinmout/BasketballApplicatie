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



        public User()
        {
            teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            this.teams.Add(team);
        }
    }
}
