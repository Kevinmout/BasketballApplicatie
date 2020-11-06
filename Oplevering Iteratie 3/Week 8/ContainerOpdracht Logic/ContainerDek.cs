using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerOpdracht_Logic
{
    public class ContainerDek
    {
        public int Hoogte { get; }
        public int Rij { get; }
        public int Lengte { get;}
        private List<Container> containers { get; }
        public ContainerDek()
        {
            containers = new List<Container>();
            Rij = 2;
            Hoogte = 5;
            Lengte = 2;
        }

        public List<Container> GetContainers()
        {
            return containers;
        }


        public void Positie(Container container)
        {
            container.X = 1;
            container.Y = 1;
            container.Z = 1;
        }
    }
}
