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
        private int unevenRowWidth;
        Container maxContainer;
        private List<Container> leftSide { get; set; }
        private List<Container> rightSide { get; set; }


        public Stack(int unevenRowWidth)
        {
            maxContainer = new Container();
            this.unevenRowWidth = unevenRowWidth;
            containersOnStack = new List<Container>();
            leftSide = new List<Container>();
            rightSide = new List<Container>();
            Width = 2;
            Height = 4;
        }

        public void FillTemp(int[] sortingArray, List<Container> containers)
        {
            if (unevenRowWidth == 1)
            {
                List<Container> max = containers;
                maxContainer = max.OrderByDescending(w => w.Weight).First();
                containers.Remove(maxContainer);
            }
            for (int i = 0; i < (Width - unevenRowWidth) / 2; i++)
            {
                leftSide.Add(containers.ElementAt(sortingArray[i] - 1));
                rightSide.Add(containers.ElementAt(sortingArray[Width - unevenRowWidth - 1 - i] - 1));
            }
            DeleteContainers(containers);
        }

        public void DeleteContainers(List<Container> containers)
        {
            for (int i = 0; i < (Width - unevenRowWidth); i++)
            {
                containers.RemoveAt(0);
            }
        }



        public void Sort()
        {
            if ((containersOnStack.Count / Width) % 2 == 0)
            {
                leftSide = leftSide.OrderBy(x => x.Weight).ToList();
                rightSide = rightSide.OrderBy(x => x.Weight).ToList();
            }
            else
            {
                leftSide = leftSide.OrderByDescending(x => x.Weight).ToList();
                rightSide = rightSide.OrderByDescending(x => x.Weight).ToList();
            }
        }




        public bool CompareWeights()
        {
            double sumLeft = leftSide.Sum(x => x.Weight);
            double sumRight = rightSide.Sum(x => x.Weight);
            bool holds;
            if (sumLeft > sumRight)
            {
                holds = CheckSixtyPercent(sumLeft, sumRight);
            }
            else
            {
                holds = CheckSixtyPercent(sumRight, sumLeft);
            }
            return holds;
        }


        public bool CheckSixtyPercent(double heaviestLoad, double lightestLoad)
        {
            return ((heaviestLoad / (heaviestLoad + lightestLoad)) * 100 <= 60);
        }














        public void AddContainersToTempStack()
        {
            foreach (var item in leftSide)
            {
                containersOnStack.Add(item);
            }
            if (unevenRowWidth == 1)
            {
                containersOnStack.Add(maxContainer);
            }
            foreach (var item in rightSide)
            {
                containersOnStack.Add(item);
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







        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }


    }
}
