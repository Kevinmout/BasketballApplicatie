using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerVervoer
{
    public class Stack
    {
        private List<Container> containersOnStack;
        public List<Container> GetContainers()
        {
            return containersOnStack;
        }

        public List<Container> GetLayer()
        {
            SortingManagement sorting = new SortingManagement(containersOnStack);
            sorting.AvailableSpace();
            List<Container> f = new List<Container>();
            return f;
        }

    }
}
