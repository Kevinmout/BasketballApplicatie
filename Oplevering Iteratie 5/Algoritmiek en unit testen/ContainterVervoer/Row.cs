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
        public int RowIndex { get; set; }

        public Row(int rowIndex)
        {
            RowIndex = rowIndex;
            stacksInRow = new List<Stack>();
            for (int i = 0; i < rowIndex; i++)
            {
                Stack stack = new Stack();
                stack.XPosition = i + 1;
                stacksInRow.Add(stack);
            }
            //Stack stack1 = new Stack();
            //Stack stack2 = new Stack();
            //Stack stack3 = new Stack();
            //Stack stack4 = new Stack();
            //stack1.XPosition = 1;
            //stack2.XPosition = 2;
            //stack3.XPosition = 3;
            //stack4.XPosition = 4;
            //stacksInRow.Add(stack1);
            //stacksInRow.Add(stack2);
            //stacksInRow.Add(stack3);
            //stacksInRow.Add(stack4);
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
        public List<Stack> SortWeightStacks()
        {
            List<Stack> a = new List<Stack>();
            List<Stack> b = new List<Stack>();
            double length = Convert.ToDouble(stacksInRow.Count);
            for (int i = 0; i < Math.Ceiling(length / 2); i++)
            {
                a.Add(stacksInRow.ElementAt(i));
            }

            int remainding = Convert.ToInt32(Math.Ceiling(length / 2));
            for (int i = remainding; i < length; i++)
            {
                b.Add(stacksInRow.ElementAt(i));
            }


            if (a.Sum(item => item.Weight) > b.Sum(item => item.Weight))
            {
                a = a.OrderBy(w => w.Weight).ToList();
                b = b.OrderBy(w => w.Weight).ToList();
                List<Stack> temp = new List<Stack>();

                for (int item = 0; item < a.Count; item++)
                {
                    temp.Add(a.ElementAt(item));
                }
                int i = 0;
                while (((b.Sum(item => item.Weight)) <= (temp.Sum(item => item.Weight))) && (i <= a.Count))
                {
                    b.Add(a[i]);
                    temp.Remove(a.ElementAt(i));
                    i += 1;
                }

                a = temp;
            }





            if (b.Sum(item => item.Weight) > a.Sum(item => item.Weight))
            {
                a = a.OrderBy(w => w.Weight).ToList();
                b = b.OrderBy(w => w.Weight).ToList();
                List<Stack> temp = new List<Stack>();
                for (int item = 0; item < b.Count; item++)
                {
                    temp.Add(b.ElementAt(item));
                }
                int i = 0;
                while ((a.Sum(item => item.Weight) <= temp.Sum(item => item.Weight)) && (i <= b.Count))
                {
                    a.Add(b[i]);
                    temp.Remove(b.ElementAt(i));
                    i += 1;
                }
                b = temp;
            }
            stacksInRow.Clear();
            foreach (Stack stack in a)
            {
                stacksInRow.Add(stack);
            }
            foreach (Stack stack in b)
            {
                stacksInRow.Add(stack);
            }
            return stacksInRow;
        }



    }
}
