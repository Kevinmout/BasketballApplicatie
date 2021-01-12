using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class SortingManagement
    {
        private List<Container> containersOnStack;
        public List<Container> ContainersOnStack()
        {
            return containersOnStack;
        }
        public List<Container> LeftContainers { get; set; }
        public List<Container> RightContainers { get; set; }
        public int[] SortingArray { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }







        public SortingManagement(List<Container> containers)
        {
            containersOnStack = new List<Container>();
            containersOnStack = containers;
            Width = 6;
            Height = 4;
            SortingArray = new int[Width];
            RightContainers = new List<Container>();
            LeftContainers = new List<Container>();
        }


        public void AvailableSpace() //done
        {
            for (int i = 0; i < Width; i++)
            {
                SortingArray[i] = i + 1;
            }
            EvenOrUneven();
        }

        public void EvenOrUneven() //done
        {
            if (Width % 2 == 0)
            {
                IndexLevellerEven();
            }
            else
            {
                ErrorHandler("Row is not even");
            }
        }

        public void IndexLevellerEven() // index on right position
        {
            for (int i = 0; i < Width; i += 2)
            {
                SortingArray[i] = i + 1;
                SortingArray[i + 1] = Width - i;
            }
            FillTemp();
        }

        public void FillTemp()
        {
            ContainerCollection c = new ContainerCollection();
            c.Add();
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
                TryAddContainersOnStack();
            }
            else
            {
                ErrorHandler("Does not hold");
            }
        }









        public void TryAddContainersOnStack()
        {
            if (CheckHeight() == true && Check120Tons() == true)
            {
                //place on existing stack
            }
            else
            {
                //place on new row
            }
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
                for (int j = i; j < Width * Height - Width; j += Width)
                {
                    weightColumn = +containersOnStack.ElementAt(j).Weight;
                }
                stackOnTop = CheckColumnWeight(weightColumn);
                i++;
            }
            return stackOnTop;
        }


        public bool CheckColumnWeight(int weight)
        {
            return (weight > 120);
        }


        public void AddContainersToTempStack()
        {
            foreach (var item in LeftContainers)
            {
                containersOnStack.Add(item);
            }
            foreach (var item in RightContainers)
            {
                containersOnStack.Add(item);
            }
        }






        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }









        public void SortUneven()
        {
            //int[] tempLeft = new int[Width / 2];
            //int[] tempRight = new int[Width / 2];
            //int[] tempMiddle = new int[1];
            //int maxValue = sortingArray.Max();
            //tempMiddle[0] = sortingArray[sortingArray.ToList().IndexOf(maxValue)];
            //for (int i = 1; i < Width / 2; i++)
            //{
            //    tempLeft[i] = sortingArray[i + 1];
            //}
            //for (int j = 0; j < Width / 2; j++)
            //{
            //    tempRight[j] = sortingArray[Width - 1 - j];
            //}
            //Array.Sort(tempLeft);
            //Array.Sort(tempRight);
        }
    }
}
