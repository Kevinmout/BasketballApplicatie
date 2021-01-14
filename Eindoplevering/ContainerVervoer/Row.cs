using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerVervoer
{
    public class Row
    {
        private readonly int width;
        private readonly int height;
        private readonly int unevenRowWidth;
        private bool bValuable;
        private int[] sortingArray;

        private List<Container> containersInRow;
        public List<Container> GetContainersInRow()
        {
            return containersInRow;
        }


        private List<Container> allContainers;
        public List<Container> GetAllContainers()
        {
            return allContainers;
        }
        
        private List<Stack> stacks;
        public List<Stack> GetStacks()
        {
            return stacks;
        }


        //constructor
        public Row(List<Container> allContainers, int unevenRowWidth, int width, int height, bool bValuable)
        {
            this.width = width;
            this.height = height;
            this.unevenRowWidth = unevenRowWidth;
            sortingArray = new int[this.width];
            this.allContainers = new List<Container>();
            stacks = new List<Stack>();
            this.allContainers = allContainers;
            containersInRow = new List<Container>();
            this.bValuable = bValuable;
        }






        //First Step
        public void AvailableSpace() //done
        {
            for (int i = 0; i < width; i++)
            {
                sortingArray[i] = i + 1;
            }
        }


        //Second Step
        public void EvenOrUnevenHeight() //layer height
        {
            if (allContainers.Count / width % 2 == 0)
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
            for (int i = 0; i < width - unevenRowWidth; i += 2)
            {
                sortingArray[i] = i + 1;
                sortingArray[i + 1] = width - i - unevenRowWidth;
            }
        }

        public void IndexLevellerUneven() // index on uneven heights
        {
            for (int i = 0; i < width - unevenRowWidth; i += 2)
            {
                sortingArray[i] = i + 2;
                sortingArray[i + 1] = width - i - 1 - unevenRowWidth;
            }
        }



        //Third Step
        public void AddStacks()
        {
            for (int i = 0; i < height; i++)
            {
                Stack stack = new Stack(unevenRowWidth, width)
                {
                    Index = i
                };
                stacks.Add(stack);
            }
        }

        //Fourth Step
        public bool FillStacks()
        {
            bool Possible = true;
            bool dummy = false;
            foreach (Stack stack in stacks.ToList())
            {
                EvenOrUnevenHeight();
                stack.UpdateContainersOnStack(containersInRow);
                stack.FillTemp(sortingArray, allContainers);
                stack.Sort();
                if (stack.CompareWeights() == false)
                {
                    ErrorHandler("No Combination Possible 20% difference");
                    Possible = false; //Delete all rows
                    break;
                }
                stack.AddContainersToTempStack();
                if (stack.TryAddContainersOnStack() == false)
                {
                    ErrorHandler("Stack too heavy.");
                    
                    foreach(Container container in stack.GetContainers().ToList()) //Place containers too heavy back
                    {
                        allContainers.Add(container);
                        stack.GetContainers().Remove(container);
                    }
                    allContainers = allContainers.OrderByDescending(x => x.Weight).ToList();
                    break;
                }
                if (dummy == false)
                {
                    containersInRow = stack.GetContainersOnStack();
                }
                if (CheckContainersLeft() == false)
                {
                    break;
                }
            }
            bValuable = true;
            if (bValuable == true)
            {
                List<Stack> tempStacks = new List<Stack>();
                tempStacks.Add(stacks.First());
                for (int i = 2; i<stacks.Count; i++)
                {
                    tempStacks.Add(stacks.ElementAt(i));
                }
                tempStacks.Add(stacks.ElementAt(1));
                stacks = tempStacks;
            }
            return Possible;
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














        ////Fourth Step
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


        ////Fifth Step
        //public void FillTempLists()
        //{
        //    stack.FillTemp(sortingArray, allContainers);
        //    stack.Sort();
        //}

        ////Sixth Step
        //public bool CheckWeightBalance()
        //{
        //    return stack.CompareWeights();
        //}

        ////Seventh Step
        //public void MergeTempLists()
        //{
        //    stack.AddContainersToTempStack();
        //}

        ////Eighth Step
        //public bool TryAddStackToExistingStack()
        //{
        //    return stack.TryAddContainersOnStack();
        //}

















    }
}
