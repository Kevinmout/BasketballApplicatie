using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class Row
    {
        public int Width { get; set; }
        public int XPosition { get; set; }
        private readonly List<Stack> stacks;
        public List<Stack> GetStacks()
        {
            return stacks;
        }
        public Row()
        {

        }



    }
}
