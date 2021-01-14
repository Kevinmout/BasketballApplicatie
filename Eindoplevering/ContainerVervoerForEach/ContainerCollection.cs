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
                Weight = 0
            };
            Container container2 = new Container()
            {
                Weight = 0
            };
            Container container3 = new Container()
            {
                Weight = 0
            };
            Container container4 = new Container()
            {
                Weight = 121
            };
            Container container5 = new Container()
            {
                Weight = 121
            };
            Container container6 = new Container()
            {
                Weight = 121
            };
            //Container container7 = new Container()
            //{
            //    Weight = 30
            //};
            //Container container8 = new Container()
            //{
            //    Weight = 30
            //};
            //Container container9 = new Container()
            //{
            //    Weight = 30
            //};
            //Container container10 = new Container()
            //{
            //    Weight = 30
            //};
            //Container container11 = new Container()
            //{
            //    Weight = 30
            //};
            //Container container12 = new Container()
            //{
            //    Weight = 30
            //};
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);
            containers.Add(container5);
            containers.Add(container6);
            //containers.Add(container7);
            //containers.Add(container8);
            //containers.Add(container9);
            //containers.Add(container10);
            //containers.Add(container11);
            //containers.Add(container12);
        }
    }
}
