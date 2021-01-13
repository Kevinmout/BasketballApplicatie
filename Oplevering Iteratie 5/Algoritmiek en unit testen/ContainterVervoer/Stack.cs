using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainterVervoer
{
    public class Stack
    {
        public int Width { get; set; }
        public Stack(int width)
        {
            Width = width;
        }



        public void FillTemp(int[] sortingArray, List<Container> existingStack)
        {
            ContainerCollection c = new ContainerCollection();
            c.GetContainers();
            for (int i = 0; i < Width / 2; i++)
            {
                LeftContainers.Add(c.GetContainers().ElementAt(SortingArray[i] - 1));
                RightContainers.Add(c.GetContainers().ElementAt(SortingArray[Width - 1 - i] - 1));
            }
            LeftContainers = LeftContainers.OrderBy(x => x.Weight).ToList();
            RightContainers = RightContainers.OrderBy(x => x.Weight).ToList();
            CompareWeights();
        }


        public void CompareWeights()
        {
            double sumLeft = LeftContainers.Sum(x => x.Weight);
            double sumRight = RightContainers.Sum(x => x.Weight);
            bool holds;
            if (sumLeft > sumRight)
            {
                holds = CheckSixtyPercent(sumLeft, sumRight);
            }
            else
            {
                holds = CheckSixtyPercent(sumRight, sumLeft);
            }
            CheckWeights(holds);
        }


        public bool CheckSixtyPercent(double heaviestLoad, double lightestLoad)
        {
            return ((heaviestLoad / (heaviestLoad + lightestLoad)) * 100 <= 60);
        }


        public void CheckWeights(bool holds)
        {
            if (holds == true)
            {
                GetRow();
            }
            else
            {
                ErrorHandler("Does not hold");
            }
        }


































































        //private List<Container> containersOnStack;
        //public List<Container> GetContainers()
        //{
        //    return containersOnStack;
        //}
        //public int XPosition { get; set; }
        //public int Weight { get; set; }
        //public bool IsValuable { get; set; }

        //public Stack()
        //{
        //    containersOnStack = new List<Container>();
        //    IsValuable = false;
        //}





        //public bool SortContainer(Container newContainer)
        //{
        //    if (newContainer.IsRefrigerated == true)
        //    {
        //        return SortRefrigerated(newContainer);
        //    }
        //    else if (newContainer.IsValuable == true)
        //    {
        //        return SortValuable(newContainer);
        //    }
        //    else
        //    {
        //        return SortNormal(newContainer);
        //    }
        //}


        //public bool SortRefrigerated(Container newContainer)
        //{
        //    if (containersOnStack.Count == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return StackContainers(newContainer);
        //    }

        //}
        //public bool StackContainers(Container newContainer)
        //{
        //    var firstContainer = containersOnStack.First();
        //    if (newContainer.Weight + (Weight - firstContainer.Weight) <= 120)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool SortValuable(Container newContainer)
        //{ 
        //    if (containersOnStack.Count == 0 && (XPosition == 1 || XPosition == 4))
        //    {
        //        IsValuable = true;
        //        return true;
        //    }
        //    else if ((XPosition == 1 || XPosition == 4) && containersOnStack.Last().IsValuable == false)
        //    {
        //        return StackContainers(newContainer);
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //public bool SortNormal(Container newContainer)
        //{
        //    if (containersOnStack.Count > 0)
        //    {
        //        return StackContainers(newContainer);
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        //public void Add(Container container)
        //{ 
        //    containersOnStack.Add(container);
        //    Weight += container.Weight;
        //}
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