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

        private List<Container> containersOnRow;


        public int Index { get; set; }
        private readonly int width;
        private readonly int unevenRowWidth;

        Container maxContainer;
        private List<Container> leftSide { get; set; }
        private List<Container> rightSide { get; set; }


        public Stack(int unevenRowWidth, int width)
        {
            maxContainer = new Container();
            this.unevenRowWidth = unevenRowWidth;
            containersOnStack = new List<Container>();
            leftSide = new List<Container>();
            rightSide = new List<Container>();
            this.width = width;
        }

        public Stack()
        {
        }

        public void UpdateContainersOnStack(List<Container> containersAlreadyOnstack)
        {
            containersOnRow = containersAlreadyOnstack;
        }




        //Make two templists left and right. If uneven also make a tempcontainer mid.
        public void FillTemp(int[] sortingArray, List<Container> containers)
        {

            if (unevenRowWidth == 1)
            {
                List<Container> max = containers;
                maxContainer = max.OrderByDescending(w => w.Weight).First();
                containers.Remove(maxContainer);
            }
            for (int i = 0; i < (width - unevenRowWidth) / 2; i++)
            {
                leftSide.Add(containers.ElementAt(sortingArray[i] - 1));
                rightSide.Add(containers.ElementAt(sortingArray[width - unevenRowWidth - 1 - i] - 1));
            }
            DeleteContainers(containers);
        }

        public void DeleteContainers(List<Container> containers)
        {
            for (int i = 0; i < (width - unevenRowWidth); i++)
            {
                containers.RemoveAt(0);
            }
        }


        //Sort by weight small to big, or big to small
        public void Sort()
        {
            if ((containersOnStack.Count / width) % 2 == 0)
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



        //Check if both halves don't exceed 20% in weight difference
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













        //Merge the containers lists to one list, Maybe you AddRange
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

        public List<Container> GetContainersOnStack()
        {
            return containersOnStack;
        }


        //Try adding the containers on top of the containers in a row
        public bool TryAddContainersOnStack()
        {
            //return CheckHeight() == true && Check120Tons() == true;
            if (containersOnRow.Count == 0)
            {
                return true;
            }
            else
            {
                return Check120Tons();
            }
            

        }


        ////Check if height doesn't exceed
        //public bool CheckHeight()
        //{
        //    return (height >= (containersOnStack.Count / width + 1));
        //}

        //Pick the column weight
        public bool Check120Tons()
        {
            int weightColumn = 0;
            bool stackOnTop = true;
            int i = 0;
            while (stackOnTop == true && i < width)
            {
                for (int j = i; j < containersOnRow.Count; j += width)
                {
                    weightColumn += containersOnRow.ElementAt(j).Weight;

                }
                i++;
                stackOnTop = CheckColumnWeight(weightColumn);
                weightColumn = 0;
            }
            return stackOnTop;
        }

        //Check if te column weight doesn't exceed 120tons
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
