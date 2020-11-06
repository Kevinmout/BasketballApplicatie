using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace BesteTijdVoorWetenschappers
{
    class Sorteren
    {
        public List<Wetenschappers> Wetenschapper { get; set; }
         public List<DoodOfLevend> doodOfLevend { get; set; }
        public Sorteren()
        {
            Wetenschapper = new List<Wetenschappers>();
            doodOfLevend = new List<DoodOfLevend>();
        }

        public void AliveOrDead()
        {
            Wetenschapper.Sort(delegate (Wetenschappers x, Wetenschappers y)
            {
                return x.geboortejaar.CompareTo(y.geboortejaar);
            });
        }
    }
}
