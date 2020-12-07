using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class Ship
    {
        Deck deck = new Deck();
        public int Weight { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        
    }
}
