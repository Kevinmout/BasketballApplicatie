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
            Width = 2;
            Height = 4;
            SortingArray = new int[Width];
            this.unevenRowWidth = unevenRowWidth;
        }


        public void AddStacks()
        {
            for (int i = 0; i < Height; i++)
            {
                Stack stack = new Stack(unevenRowWidth);
                stacks.Add(stack);
            }
        }

        public void EachStackDoProcedure()
        {
            foreach (Stack item in stacks)
            {
                AvailableSpace();
                EvenOrUnevenHeight();
                FillTempLists(item);
                if (CheckWeightBalance(item) == false)
                {
                    ErrorHandler("No Combination Possible");
                }
                MergeTempLists(item);
                if (TryAddStackToExistingStack(item) == false)
                {
                    ErrorHandler("Stack too high or too heavy.");
                    // Add to next Row
                }
                else
                {
                    // Add to this Row
                }
                if (CheckContainersLeft() != true)
                {
                    break;
                }
            }
        }









        //First Step
        public void AvailableSpace() //done
        {
            for (int i = 0; i < Width; i++)
            {
                SortingArray[i] = i + 1;
            }
        }


        //Second Step
        public void EvenOrUnevenHeight() //layer height
        {
            if (allContainers.Count / Width % 2 == 0)
            {
                IndexLevellerEven();
            }
            else
            {
                IndexLevellerUneven();
            }
        }

        public void IndexLevellerEven() // index on even heights
        {
            for (int i = 0; i < Width - unevenRowWidth; i += 2)
            {
                SortingArray[i] = i + 1;
                SortingArray[i + 1] = Width - i - unevenRowWidth;
            }
        }

        public void IndexLevellerUneven() // index on uneven heights
        {
            for (int i = 0; i < Width - unevenRowWidth; i += 2)
            {
                SortingArray[i] = i + 2;
                SortingArray[i + 1] = Width - i - 1 - unevenRowWidth;
            }
        }



        //Third Step
        //public Stack AddStack(Stack possibleStack)
        //{
        //    if (possibleStack == null)
        //    {
        //        stack = new Stack(unevenRowWidth);
        //        return stack;
        //    }
        //    else
        //    {
        //        stacks.Add(possibleStack);
        //        return possibleStack;
        //    }
        //}




        //Fourth Step
        //public Stack BuildStack()
        //{
        //    FillTempLists();
        //    if (CheckWeightBalance() == false)
        //    {
        //        ErrorHandler("No Combination Possible");
        //    }
        //    MergeTempLists();
        //    if (TryAddStackToExistingStack() == false)
        //    {
        //        ErrorHandler("Stack too high or too heavy.");
        //        // Add to next Row
        //    }
        //    else
        //    {
        //        // Add to this Row
        //        stacks.Add(stack);
        //        stack = null;
        //    }
        //    return stack;
        //}




        //Fifth Step
        public void FillTempLists(Stack stack)
        {
            stack.FillTemp(SortingArray, allContainers);
            stack.Sort();
        }

        //Sixth Step
        public bool CheckWeightBalance(Stack stack)
        {
            return stack.CompareWeights();
        }

        //Seventh Step
        public void MergeTempLists(Stack stack)
        {
            stack.AddContainersToTempStack();
        }

        //Eighth Step
        public bool TryAddStackToExistingStack(Stack stack)
        {
            return stack.TryAddContainersOnStack();
        }




        //Nineth Step
        public bool CheckContainersLeft()
        {
            return allContainers.Count != 0;
        }






        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }





    }
}
