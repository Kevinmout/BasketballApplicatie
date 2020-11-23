using System;
using System.Collections.Generic;

namespace ApplicatieBasketbal.Models.DBModels
{
    public partial class Speler
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ActiveTeam { get; set; }
        public int Games { get; set; }
        public double Points { get; set; }
        public double Rebounds { get; set; }
        public double Assists { get; set; }
        public double Blocks { get; set; }

        public List<Speler> GetSpelers()
        {
            List<Speler> spelers = new List<Speler>();
            spelers.Add(new Speler
            {
                FirstName = FirstName,
                LastName= LastName,
                ActiveTeam = ActiveTeam
            });
            return spelers;
        }
    }
}
