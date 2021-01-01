using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainterVervoer
{
    public class Row
    {
        private List<Stack> stacksInRow;
        public List<Stack> GetStacks()
        {
            return stacksInRow;
        }
        public int Number { get; set; }

        public Row()
        {
            stacksInRow = new List<Stack>();
            Stack stack1 = new Stack();
            Stack stack2 = new Stack();
            Stack stack3 = new Stack();
            Stack stack4 = new Stack();
            stack1.XPosition = 1;
            stack2.XPosition = 2;
            stack3.XPosition = 3;
            stack4.XPosition = 4;
            stacksInRow.Add(stack1);
            stacksInRow.Add(stack2);
            stacksInRow.Add(stack3);
            stacksInRow.Add(stack4);
        }


        /// <summary>
        /// Pick the stack with the lowest amount of containers
        /// </summary>
        /// <returns>stack</returns>
        public Stack ChooseStack()
        {
            int lowest = int.MaxValue;
            Stack stack = new Stack();
            foreach (Stack ExistingStack in stacksInRow)
            {
                if (ExistingStack.GetContainers().Count <= lowest)
                {
                    lowest = ExistingStack.GetContainers().Count;
                    stack = ExistingStack;
                }
            }
            return stack;
        }




        /// <summary>
        /// Add container to a existing stack
        /// </summary>
        /// <param name="container"></param>
        public void AddToExistingStack(Container container, List<Container> containers)
        {
            if (ChooseStack().SortContainer(container) == true)
            {
                ChooseStack().Add(container);
                containers.Remove(container);
            }
        }


        /// <summary>
        /// Add refrigerated containers
        /// </summary>
        /// <param name="containers"></param>
        public void AddRefrigerated(List<Container> containers)
        {
            foreach (Container container in containers.ToList())
            {
                if (container.IsRefrigerated == true)
                {
                    AddToExistingStack(container,containers);

                }
            }
            AddNormal(containers);
        }


        /// <summary>
        /// Add containers to a stack that isn't valuable nor refrigerated
        /// </summary>
        /// <param name="containers"></param>
        public void AddNormal(List<Container> containers)
        {
            foreach (Container container in containers.ToList())
            {
                if (container.IsRefrigerated == false && container.IsValuable == false)
                {
                    AddToExistingStack(container,containers);
                }
            }
            AddValuable(containers);
        }



        /// <summary>
        /// Add valuable container to a stack
        /// </summary>
        /// <param name="containers"></param>
        public void AddValuable(List<Container> containers)
        {
            //SortWeightStacks();
            foreach (Container container in containers.ToList())
            {
                if (container.IsValuable == true)
                {
                    AddAtTheTop(container,containers);
                }
            }
            SortWeightStacks();
        }



        /// <summary>
        /// Add valuable container on top of other containers
        /// </summary>
        /// <param name="container"></param>
        public void AddAtTheTop(Container container, List<Container> containers)
        {
            foreach (Stack ExistingStack in stacksInRow)
            {
                if (ExistingStack.SortContainer(container) == true)
                {
                    ExistingStack.Add(container);
                    containers.Remove(container);
                }
            }
        }





        /// <summary>
        /// Sort the stacks, that the weight is good.
        /// </summary>
        public void SortWeightStacks()
        {
            var firstStack = stacksInRow.ElementAt(0).Weight;
            var secondStack = stacksInRow.ElementAt(1).Weight;
            var thirdStack = stacksInRow.ElementAt(2).Weight;
            var fourthStack = stacksInRow.ElementAt(3).Weight;
            if ((firstStack+secondStack) * 1.2 >= (thirdStack + fourthStack) || (firstStack + secondStack) * 0.8 >= (thirdStack + fourthStack))
            {
                stacksInRow.ElementAt(0).XPosition = 1;
                stacksInRow.ElementAt(1).XPosition = 2;
                stacksInRow.ElementAt(2).XPosition = 3;
                stacksInRow.ElementAt(3).XPosition = 4;
            }
            else if ((firstStack + thirdStack) * 1.2 >= (secondStack + fourthStack) || (firstStack + thirdStack) * 0.8 >= (secondStack + fourthStack))
            {
                stacksInRow.ElementAt(0).XPosition = 1;
                stacksInRow.ElementAt(1).XPosition = 3;
                stacksInRow.ElementAt(2).XPosition = 2;
                stacksInRow.ElementAt(3).XPosition = 4;
            }
            
        }



    }
}
