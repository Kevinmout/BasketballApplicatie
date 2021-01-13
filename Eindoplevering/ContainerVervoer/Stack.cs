using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Width { get; set; }
        public int Height { get; set; }

        public List<Container> LeftSide { get; set; }
        public List<Container> RightSide { get; set; }


        public Stack()
        {
            containersOnStack = new List<Container>();
            LeftSide = new List<Container>();
            RightSide = new List<Container>();
            Width = 6;
            Height = 4;
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

            containersOnStack.Add(container5);
            containersOnStack.Add(container4);
            containersOnStack.Add(container2);
            containersOnStack.Add(container6);
            containersOnStack.Add(container3);
            containersOnStack.Add(container1);
        }







        public void FillTemp(int[] sortingArray)
        {
            ContainerCollection c = new ContainerCollection();
            c.Add();
            c.GetContainers();
            for (int i = 0; i < Width / 2; i++)
            {
                LeftSide.Add(c.GetContainers().ElementAt(sortingArray[i] - 1));
                RightSide.Add(c.GetContainers().ElementAt(sortingArray[Width - 1 - i] - 1));
            }
            LeftSide = LeftSide.OrderBy(x => x.Weight).ToList();
            RightSide = RightSide.OrderBy(x => x.Weight).ToList();

            
        }


        public bool CompareWeights()
        {
            double sumLeft = LeftSide.Sum(x => x.Weight);
            double sumRight = RightSide.Sum(x => x.Weight);
            bool holds;
            if (sumLeft > sumRight)
            {
                holds = CheckSixtyPercent(sumLeft, sumRight);
            }
            else
            {
                holds = CheckSixtyPercent(sumRight, sumLeft);
            }
            return CheckWeights(holds);
        }


        public bool CheckSixtyPercent(double heaviestLoad, double lightestLoad)
        {
            return ((heaviestLoad / (heaviestLoad + lightestLoad)) * 100 <= 60);
        }


        public bool CheckWeights(bool holds)
        {
            if (holds == true)
            {
                return true;
            }
            else
            {
                ErrorHandler("Does not hold");
                return false;
            }
        }









        public bool TryAddContainersOnStack()
        {
            return CheckHeight() == true && Check120Tons() == true;
        }


        public bool CheckHeight()
        {
            return (Height >= (containersOnStack.Count / Width + 1));
        }


        public bool Check120Tons()
        {
            AddContainersToTempStack();
            int weightColumn = 0;
            bool stackOnTop = true;
            int i = 0;
            while (stackOnTop == true && i < Width)
            {
                for (int j = i; j < containersOnStack.Count; j += Width)
                {
                    weightColumn += containersOnStack.ElementAt(j).Weight;

                }
                i++;
                stackOnTop = CheckColumnWeight(weightColumn);
                weightColumn = 0;
            }
            return stackOnTop;
        }


        public bool CheckColumnWeight(int weight)
        {
            return (weight <= 120);
        }


        public void AddContainersToTempStack()
        {
            foreach (var item in LeftSide)
            {
                containersOnStack.Add(item);
            }
            foreach (var item in RightSide)
            {
                containersOnStack.Add(item);
            }
        }




        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }


    }
}
