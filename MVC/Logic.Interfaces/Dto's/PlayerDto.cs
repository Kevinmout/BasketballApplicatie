using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interface.DTOs
{
    public class PlayerDto
    {
        public int IdPlayer { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public int Points { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Blocks { get; set; }
        public string Nationality { get; set; }
    }
}