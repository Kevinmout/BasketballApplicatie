using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class ContainerCollection
    {
        private List<Container> containers;
        public List<Container> GetContainers()
        {
            return containers;
        }
        public ContainerCollection()
        {
            containers = new List<Container>();
        }

        public void Add(Container container)
        {
            containers.Add(container);
        }
    }
}
