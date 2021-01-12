using System;
using System.Collections.Generic;
using System.Linq;
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
            if (container.Weight >= 4 && container.Weight <= 30)
            containers.Add(container);
        }
        public void OrderByWeight()
        {
            containers = containers.OrderByDescending(w => w.Weight).ToList();
        }



    }
}
