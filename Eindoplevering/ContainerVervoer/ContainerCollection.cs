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
                Weight = 11
            };
            Container container2 = new Container()
            {
                Weight = 12
            };
            Container container3 = new Container()
            {
                Weight = 13
            };
            Container container4 = new Container()
            {
                Weight = 14
            };
            Container container5 = new Container()
            {
                Weight = 15
            };
            Container container6 = new Container()
            {
                Weight = 16
            };
            Container container7 = new Container()
            {
                Weight = 17
            };
            Container container8 = new Container()
            {
                Weight = 18
            };

            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            containers.Add(container7);
            containers.Add(container8);
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            containers.Add(container7);
            containers.Add(container8);
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            containers.Add(container7);
            containers.Add(container8);
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            containers.Add(container7);
            containers.Add(container8);

        }
    }
}
