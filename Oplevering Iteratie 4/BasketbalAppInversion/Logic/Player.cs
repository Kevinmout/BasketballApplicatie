using Logic;
using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APPBasketbal.Models
{
    public class Player
    {
        [Key]
        public int IdPlayer { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public double Points { get; set; }
        public double Assists { get; set; }
        public double Rebounds { get; set; }
        public double Blocks { get; set; }
        public string Nationality { get; set; }
    }
}
