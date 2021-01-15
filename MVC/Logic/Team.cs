using APPBasketbal.Models;
using Factory;
using Logic.Interface.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APPBasketbal.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

    }
}
