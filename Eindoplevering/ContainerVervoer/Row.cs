using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class Row
    {
        public int Width { get; set; }
        public int[] SortingArray { get; set; }
        public int Height { get; set; }
        public bool NextRow { get; set; }
        private int unevenRowWidth;
        public List<Container> allContainers;
        private readonly List<Stack> stacks;
        public List<Stack> GetStacks()
        {
            return stacks;
        }


        //constructor
        public Row(List<Container> allContainers, int unevenRowWidth)
        {
            this.allContainers = new List<Container>();
            this.allContainers = allContainers;
            NextRow = false;
            stacks = new List<Stack>();
            Width = 4;
            Height = 4;
            SortingArray = new int[Width];
            this.unevenRowWidth = unevenRowWidth;
        }


        public void AvailableSpace() //done
        {
            for (int i = 0; i < Width; i++)
            {
                SortingArray[i] = i + 1;
            }
            EvenOrUnevenHeight();
        }





        public void EvenOrUnevenHeight() //layer height
        {
            Stack stack = new Stack(unevenRowWidth);
            if (allContainers.Count / Width % 2 == 0)
            {
                IndexLevellerEven(stack);
            }
            else
            {
                IndexLevellerUneven(stack);
            }
        }

        public void IndexLevellerEven(Stack stack) // index on even heights
        {
            for (int i = 0; i < Width - unevenRowWidth; i += 2)
            {
                SortingArray[i] = i + 1;
                SortingArray[i + 1] = Width - i - unevenRowWidth;
            }
            bool even = true;
            CheckCombination(stack, even);
        }

        public void IndexLevellerUneven(Stack stack) // index on uneven heights
        {
            for (int i = 0; i < Width - unevenRowWidth; i += 2)
            {
                SortingArray[i] = i + 2;
                SortingArray[i + 1] = Width - i - 1 - unevenRowWidth;
            }
            bool even = false;
            CheckCombination(stack, even);
        }


        public void CheckCombination(Stack stack, bool even)
        {
            stack.FillTemp(SortingArray, allContainers);
            stack.Sort(even);
            if (stack.CompareWeights() == true)
            {
                CheckToStackOnCurrentStack(stack);
            }
            else
            {
                ErrorHandler("No combination");
            }
        }


        public void CheckToStackOnCurrentStack(Stack stack)
        {
            allContainers.RemoveRange(0, Width - unevenRowWidth);
            if (stack.TryAddContainersOnStack() == true)
            {
                stacks.Add(stack);
                NextRow = false;
            }
            else
            {
                //ErrorHandler("Next Row");
                NextRow = true;

            }

            AssignAvailableSpaces();
        }


        public void AssignAvailableSpaces()
        {
            if (allContainers.Count != 0)
            {
                AvailableSpace();
            }
            else
            {
                ErrorHandler("End");
            }

        }






        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }
    }
}
