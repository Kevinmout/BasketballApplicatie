using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class SortingManagement
    {
        private int[] sortingArray;
        public int[] SortingArray
        {
            get
            {
                return sortingArray;
            }
            set
            {
                sortingArray = value;
            }
        }
        public int Width { get; set; }







        public SortingManagement()
        {
            Width = 6;
            sortingArray = new int[Width];
        }











        public void AvailableSpace() //done
        {
            int j = 1;
            for (int i = 0; i < Width; i++)
            {
                sortingArray[i] = j;
                j++;
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





        public void IndexLevellerEven()
        {
            for (int i = 0; i < Width; i += 2)
            {
                sortingArray[i] = i + 1;
                sortingArray[i + 1] = Width - i;
            }
            SortEven();
        }





        public void SortEven()
        {
            int[] tempLeft = new int[Width / 2];
            int[] tempRight = new int[Width / 2];
            for (int i = 0; i < Width / 2; i++)
            {
                tempLeft[i] = sortingArray[i];
            }
            for (int j = 0; j < Width / 2; j++)
            {
                tempRight[j] = sortingArray[Width - 1 - j];
            }
            Array.Sort(tempLeft);
            Array.Sort(tempRight);
            FillTemp(tempLeft, tempRight);
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





        public void FillTemp(int[] tempLeft, int[] tempRight)
        {
            ContainerCollection c = new ContainerCollection();
            c.Add();
            c.GetContainers();
            List<Container> leftContainers = new List<Container>();
            List<Container> rightContainers = new List<Container>();
            for (int i = 0; i < Width / 2; i++)
            {
                leftContainers.Add(c.GetContainers().ElementAt(tempLeft[i] - 1));
                rightContainers.Add(c.GetContainers().ElementAt(tempRight[i] - 1));
            }
            CheckWeight(leftContainers, rightContainers);
        }

        public void CheckWeight(List<Container> leftContainers, List<Container> rightContainers)
        {
            int sumLeft = leftContainers.Sum(x => x.Weight);
            int sumRight = rightContainers.Sum(x => x.Weight);
            if (sumLeft > sumRight)
            {
                CheckSixtyPercent(sumLeft, sumRight);
            }
            else
            {
                CheckFourtyPercent(sumLeft, sumRight);
            }
        }

        public void CheckSixtyPercent(int sumLeft, int sumRight)
        {
            if (sumLeft / (sumRight + sumLeft) * 100 <= 60)
            {
                LessThan120Tons();
            }
            else
            {
                ErrorHandler("Exceeds more than 20% on the left side");
            }
        }

        public void CheckFourtyPercent(int sumLeft, int sumRight)
        {
            if (sumLeft / (sumRight + sumLeft) * 100 >= 40)
            {
                LessThan120Tons();
            }
            else
            {
                ErrorHandler("Exceeds more than 20% on the right side");
            }
        }













        public void LessThan120Tons()
        {

        }





        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }



    }
}
