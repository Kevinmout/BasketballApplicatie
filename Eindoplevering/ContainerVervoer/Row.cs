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
        private readonly List<Stack> stacks;
        public List<Stack> GetStacks()
        {
            return stacks;
        }
        
        
        //constructor
        public Row()
        {
            stacks = new List<Stack>();
            Width = 6;
            Height = 4;
            SortingArray = new int[Width];
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
            Stack stack = new Stack();
            PlaceOnExistingStack(stack);
        }




        public void PlaceOnExistingStack(Stack stack)
        {
            stack.FillTemp(SortingArray);
            if (stack.CompareWeights() == true)
            {
                if (stack.TryAddContainersOnStack() == true)
                {
                    stacks.Add(stack);
                }
                else
                {
                    ErrorHandler("Next Row");
                }
            }else
            {
                ErrorHandler("No combination");
            }
        }





        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }
    }
}
