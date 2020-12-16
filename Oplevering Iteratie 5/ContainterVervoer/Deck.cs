using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class Deck
    {
        private readonly List<Stack> stacks;
        public List<Stack> GetStacks()
        {
            return stacks;
        }
        private int amountOfStacks;
        public int AmountOfStacks
        {
            get { return amountOfStacks; }
            set { amountOfStacks = AmountOfStacks; }
        }


        public Deck()
        {
            stacks = new List<Stack>();
        }



        public void SortRow(List<Container> containers)
        {
            containers.Sort();
            foreach (Container container in containers)
            {

            }
        }




        //public void SortRefrigerated(List<Container> containers)
        //{
        //    foreach (Container container in containers)
        //    {
        //        if (container.IsRefrigerated == true)
        //        {
        //            bool containerAdded = false;
        //            int xposition = 0;
        //            int yposition = 0;
        //            foreach (Stack existingStack in stacks)
        //            {
        //                xposition = existingStack.XPosition;
        //                yposition = existingStack.YPosition;
        //                if (existingStack.TryAddRefrigerated(container) == true)
        //                {
        //                    existingStack.Add(container);
        //                    containerAdded = true;
        //                    break;
        //                }
        //            }
        //            if (containerAdded == false)
        //            {
        //                Stack stack = new Stack();
        //                if (xposition == 0)
        //                {
        //                    stack.XPosition = 1;
        //                    stack.YPosition = 1;
        //                }
        //                else if (xposition < 4 && xposition > 0)
        //                {
        //                    stack.XPosition = xposition+1;
        //                    stack.YPosition = yposition;
        //                }
        //                stacks.Add(stack);
        //                stack.Add(container);
        //                amountOfStacks++;
        //            }
        //        }
        //    }
        //}


        //public void SortAllHeavy(List<Container> containers)
        //{
        //    foreach (Container container in containers)
        //    {
        //        if (container.IsRefrigerated == false && container.IsValuable == false)
        //        {
        //            int xposition = 0;
        //            int yposition = 0;
        //            bool containerAdded = false;
        //            foreach (Stack existingStack in stacks)
        //            {
        //                xposition = existingStack.XPosition;
        //                yposition = existingStack.YPosition;
        //                if (existingStack.TryAddContainer(container) == true)
        //                {
        //                    existingStack.Add(container);
        //                    containerAdded = true;
        //                    break;
        //                }
        //            }
        //            if (containerAdded == false)
        //            {
        //                Stack stack = new Stack();
        //                if (xposition < 4 && xposition > 0)
        //                {
        //                    stack.XPosition = xposition + 1;
        //                    stack.YPosition = yposition;
        //                }
        //                else
        //                {
        //                    stack.XPosition = 1;
        //                    stack.YPosition = yposition + 1;
        //                }
        //                stacks.Add(stack);
        //                stack.Add(container);
        //                amountOfStacks++;
        //            }
        //        }
        //    }
        //}



        //public void SortAllValuable(List<Container> containers)
        //{
        //    foreach (Container container in containers)
        //    {
        //        if (container.IsValuable == true)
        //        {
        //            int xposition = 0;
        //            int yposition = 0;
        //            bool containerAdded = false;
        //            foreach (Stack existingStack in stacks)
        //            {
        //                xposition = existingStack.XPosition;
        //                yposition = existingStack.YPosition;
        //                if (existingStack.TryAddValuable(container) == true)
        //                {
        //                    existingStack.Add(container);
        //                    containerAdded = true;
        //                    break;
        //                }
        //            }
        //            if (containerAdded == false)
        //            {
        //                Stack stack = new Stack();
        //                if (xposition < 4 && xposition > 0)
        //                {
        //                    stack.XPosition = xposition + 1;
        //                    stack.YPosition = yposition;
        //                }
        //                else
        //                {
        //                    stack.XPosition = 1;
        //                    stack.YPosition = yposition + 1;
        //                }
        //                stacks.Add(stack);
        //                stack.Add(container);
        //                amountOfStacks++;
        //            }
        //        }
        //    }
        //}


        //public void SortStacks()
        //{
        //    List<Stack> stackRow = new List<Stack>();
        //    foreach (Stack stack in stacks)
        //    {
        //        if(stack.YPosition == 2)
        //        {
        //            stackRow.Add(stack);
        //        }
        //    }
            
        //}





    }
}
