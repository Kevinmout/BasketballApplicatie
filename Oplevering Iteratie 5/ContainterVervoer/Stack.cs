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
        public int YPosition { get; set; }
        public int Weight { get; set; }
        
        public Stack()
        {
            containersOnStack = new List<Container>();
        }

        public bool TryAddRefrigerated(Container newContainer)
        {
            var firstContainer = containersOnStack.First();
            if ((XPosition == 1 || XPosition == 4) && containersOnStack.Count() < 4)
            {
                YPosition = 1;
                return true;
            }
            else if ((XPosition == 2 || XPosition == 3) && (Weight - firstContainer.Weight + newContainer.Weight) <= 120)
            {
                YPosition = 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryAddContainer(Container newContainer)
        {
            var firstContainer = containersOnStack.First();
            if ((XPosition == 1 || XPosition == 4) && containersOnStack.Count() < 4)
            {
                return true;
            }
            else if ((XPosition == 2 || XPosition == 3) && ((Weight - firstContainer.Weight + newContainer.Weight) <= 120))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        

        public bool TryAddValuable(Container newContainer)
        {
            var firstContainer = containersOnStack.First();
            if ((XPosition == 1 || XPosition == 4 )&& (containersOnStack.Find(x => (x.IsValuable == true)) == null) && ((Weight - firstContainer.Weight + newContainer.Weight) <= 120))
            {
                return true;
            }
            else
            {
                return false;
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