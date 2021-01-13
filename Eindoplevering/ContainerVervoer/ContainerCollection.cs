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
                Weight = 1
            };
            Container container2 = new Container()
            {
                Weight = 2
            };
            Container container3 = new Container()
            {
                Weight = 3
            };
            Container container4 = new Container()
            {
                Weight = 4
            };
            Container container5 = new Container()
            {
                Weight = 5
            };
            Container container6 = new Container()
            {
                Weight = 6
            };
            Container container7 = new Container()
            {
                Weight = 7
            };
            Container container8 = new Container()
            {
                Weight = 8
            };
            //Container container9 = new Container()
            //{
            //    Weight = 9
            //};
            //Container container10 = new Container()
            //{
            //    Weight = 10
            //};
            //Container container11 = new Container()
            //{
            //    Weight = 11
            //};
            //Container container12 = new Container()
            //{
            //    Weight = 12
            //};
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            containers.Add(container7);
            containers.Add(container8);
            //containers.Add(container9);
            //containers.Add(container10);
            //containers.Add(container11);
            //containers.Add(container12);
        }
    }
}
