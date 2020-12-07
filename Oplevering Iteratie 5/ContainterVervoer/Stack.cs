using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class Stack
    {
        private List<Container> containersOnStack;
        public List<Container> GetContainers()
        {
            return containersOnStack;
        }

        public Stack()
        {
            containersOnStack = new List<Container>();
        }

        public bool TryAddStackRefrigerated()
        {
            if (containersOnStack.Count <= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryAddStackHeavy()
        {
            foreach (Container container in containersOnStack)
            {
                if (container.IsRefrigerated == true)
                {
                    return false;
                }
                else if (containersOnStack.Count > 3)
                {
                    return false;
                }
            }
            return true;
        }

        public bool TryAddStackLessHeavy()
        {
            foreach (Container container in containersOnStack)
            {
                if (container.IsRefrigerated == true)
                {
                    return false;
                }
                else if (containersOnStack.Count > 4)
                {
                    return false;
                }
            }
            return true;
        }


        public bool TryAddStackValuable()
        {
            foreach (Container container in containersOnStack)
            {
                if (containersOnStack.Count == 5 && container.IsValuable == true)
                {
                    return false;
                }
            }
            return true;
        }

        public void Add(Container container)
        {
            containersOnStack.Add(container);
        }
    }
}
