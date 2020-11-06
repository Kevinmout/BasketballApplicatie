using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerOpdracht_Logic
{
    public class Container
    {
        public int Gewicht { get;}
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public bool Koeling { get; }
        public bool Waardevol { get; }

        public Container(int gewicht, bool koeling, bool waardevol)
        {
            Gewicht = gewicht;
            Koeling = koeling;
            Waardevol = waardevol;
        }
    }
}
