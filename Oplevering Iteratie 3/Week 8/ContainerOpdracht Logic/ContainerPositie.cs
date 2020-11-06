using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ContainerOpdracht_Logic
{
    public class ContainerPositie
    {
        //oneven is links
        //even is rechts
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public void Add(Container container)
        {
            container.X = 1;
        }
    }
}
