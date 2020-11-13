using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC
{
    public class Player
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string ActiveTeam { get; }
        public int Games { get; }
        public double Points { get; }
        public double Assists { get; }
        public double Rebounds { get; }
        public double Blocks { get; }

        public Player(string lastname, string firstName, string activeteam, int games, double points, double assists, double rebounds, double blocks)
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
