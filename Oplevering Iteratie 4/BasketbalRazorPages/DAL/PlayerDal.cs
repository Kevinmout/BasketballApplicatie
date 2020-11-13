using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlayerDal
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public int Games { get; set; }
        public double Points { get; set; }
        public double Assists { get; set; }
        public double Rebounds { get; set; }
        public double Blocks { get; set; }
        public PlayerDal(string lastname, string firstName, string activeteam, int games, double points, double assists, double rebounds, double blocks)
        {
            LastName = lastname;
            FirstName = firstName;
            ActiveTeam = activeteam;
            Games = games;
            Points = points;
            Assists = assists;
            Rebounds = rebounds;
            Blocks = blocks;
        }
    }
}
