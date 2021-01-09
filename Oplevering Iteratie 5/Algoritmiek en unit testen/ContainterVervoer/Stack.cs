using System;
using System.Collections.Generic;
using System.Linq;
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
        public int XPosition { get; set; }
        public int Weight { get; set; }
        public bool IsValuable { get; set; }
        
        public Stack()
        {
            containersOnStack = new List<Container>();
            IsValuable = false;
        }





        public bool SortContainer(Container newContainer)
        {
            if (newContainer.IsRefrigerated == true)
            {
                return SortRefrigerated(newContainer);
            }
            else if (newContainer.IsValuable == true)
            {
                return SortValuable(newContainer);
            }
            else
            {
                return SortNormal(newContainer);
            }
        }


        public bool SortRefrigerated(Container newContainer)
        {
            if (containersOnStack.Count == 0)
            {
                return true;
            }
            else
            {
                return StackContainers(newContainer);
            }

        }
        public bool StackContainers(Container newContainer)
        {
            var firstContainer = containersOnStack.First();
            if (newContainer.Weight + (Weight - firstContainer.Weight) <= 120)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SortValuable(Container newContainer)
        { 
            if (containersOnStack.Count == 0 && (XPosition == 1 || XPosition == 4))
            {
                IsValuable = true;
                return true;
            }
            else if ((XPosition == 1 || XPosition == 4) && containersOnStack.Last().IsValuable == false)
            {
                return StackContainers(newContainer);
            }
            else
            {
                return false;
            }
            
        }

        public bool SortNormal(Container newContainer)
        {
            if (containersOnStack.Count > 0)
            {
                return StackContainers(newContainer);
            }
            else
            {
                return true;
            }
        }


        public void Add(Container container)
        { 
            containersOnStack.Add(container);
            Weight += container.Weight;
        }
    }
}



































//public bool TryAddStackHeavy()
//{
//    foreach (Container container in containersOnStack)
//    {
//        if (container.IsRefrigerated == true)
//        {
//            return false;
//        }
//        else if (containersOnStack.Count > 3)
//        {
//            return false;
//        }
//    }
//    return true;
//}

//public bool TryAddStackLessHeavy()
//{
//    foreach (Container container in containersOnStack)
//    {
//        if (container.IsRefrigerated == true)
//        {
//            return false;
//        }
//        else if (containersOnStack.Count > 4)
//        {
//            return false;
//        }
//    }
//    return true;
//}


//public bool TryAddStackValuable()
//{
//    if (XPosition == 1 || XPosition == 4)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }

//}