using System;
using System.Collections.Generic;
using System.Text;

namespace BesteTijdVoorWetenschappers
{
    class Sorteren
    {
        public List<Wetenschappers> Wetenschapper { get; set; }

        public Sorteren()
        {
            Wetenschapper = new List<Wetenschappers>();
        }

        public int OldestByBirthYear()
        {
            double minYear = double.MaxValue;
            foreach (Wetenschappers item in Wetenschapper)
            {
                if (minYear > item.geboortejaar)
                {
                    minYear = item.geboortejaar;
                }
            }
            return Convert.ToInt32(minYear);
        }
    }
}
