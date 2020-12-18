using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logic
{
    public class Team : ITeam
    {
        [Key]
        public string IdTeam { get; set; }
        public string TeamName { get; set; }
    }
}
