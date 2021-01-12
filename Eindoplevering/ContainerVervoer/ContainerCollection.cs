using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer
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
        public void Add()
        {
            Container container1 = new Container()
            {
                Weight = 10
            };
            Container container2 = new Container()
            {
                Weight = 20
            };
            Container container3 = new Container()
            {
                Weight = 30
            };
            Container container4 = new Container()
            {
                Weight = 40
            };
            Container container5 = new Container()
            {
                Weight = 50
            };
            Container container6 = new Container()
            {
                Weight = 60
            };
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
        }
    }
}
