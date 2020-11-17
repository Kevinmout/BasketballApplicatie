using Auto.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Logic
{
    public class Player
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public int Games { get; set; }
        public double Points { get; set; }
        public double Assists { get; set; }
        public double Rebounds { get; set; }
        public double Blocks { get; set; }

    }
}
