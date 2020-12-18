using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interface.DTOs
{
    public class TeamDto
    {
        public string Name { get; set; }
        public List<Player> players { get; set; }
    }
}
