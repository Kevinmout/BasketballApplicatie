using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APPBasketbal.Models
{
    public class PlayerClass : IGetName
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public int Games { get; set; }
        public double Points { get; set; }
        public double Rebounds { get; set; }
        public double Assists { get; set; }
        public double Blocks { get; set; }

        public string getName()
        {
            return FirstName;
        }
    }
}
