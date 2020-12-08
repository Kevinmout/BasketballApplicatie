using System;
using System.Collections.Generic;
using System.Text;

namespace ContainterVervoer
{
    public class Deck
    {
        private List<Stack> stacks;
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

        public int XPositionD { get; set; }
        public int YPositionD { get; set; }
        public int XPosition2 { get; set; }
        public int YPosition2 { get; set; }


        public Deck()
        {
            YPositionD = 1;
            YPosition2 = 2;
            stacks = new List<Stack>();
        }








        public void SortRefrigerated(List<Container> containers)
        {
            foreach (Container container in containers)
            {
                if (container.IsRefrigerated == true && container.IsValuable == false)
                {
                    bool containerAdded = false;
                    foreach (Stack existingStack in stacks)
                    {
                        if (existingStack.TryAddStackRefrigerated() == true)
                        {
                            existingStack.Add(container);
                            containerAdded = true;
                            break;
                        }
                    }
                    if (containerAdded == false)
                    {
                        Stack stack = new Stack();
                        XPositionD ++;
                        if (XPositionD == 4)
                        {
                            XPositionD = 1;
                            YPositionD++;
                        }
                        stack.XPosition = XPositionD;
                        stack.YPosition = YPositionD;
                        stacks.Add(stack);
                        stack.Add(container);
                        amountOfStacks++;
                    }
                }
            }
        }



        public void SortAllHeavy(List<Container> containers)
        {
            foreach (Container container in containers)
            {
                if (container.Weight == 30 && container.IsRefrigerated == false && container.IsValuable == false)
                {
                    bool containerAdded = false;
                    foreach (Stack existingStack in stacks)
                    {
                        if (existingStack.TryAddStackHeavy() == true)
                        {
                            existingStack.Add(container);
                            containerAdded = true;
                            break;
                        }
                    }
                    if (containerAdded == false)
                    {
                        Stack stack = new Stack();
                        XPosition2++;
                        if (XPosition2 == 4)
                        {
                            XPosition2 = 1;
                            YPosition2++;
                        }
                        stack.XPosition = XPosition2;
                        stack.YPosition = YPosition2;
                        stacks.Add(stack);
                        stack.Add(container);
                        amountOfStacks++;
                    }
                }
            }
        }







        public void SortAllLessHeavy(List<Container> containers)
        {
            foreach (Container container in containers)
            {
                if (container.Weight < 30 && container.IsRefrigerated == false && container.IsValuable == false)
                {
                    bool containerAdded = false;
                    foreach (Stack existingStack in stacks)
                    {
                        if (existingStack.TryAddStackLessHeavy() == true)
                        {
                            existingStack.Add(container);
                            containerAdded = true;
                            break;
                        }
                    }
                    if (containerAdded == false)
                    {
                        Stack stack = new Stack();
                        XPositionD++;
                        if (XPositionD == 4)
                        {
                            XPositionD = 1;
                            YPositionD++;
                        }
                        stack.XPosition = XPositionD;
                        stack.YPosition = YPositionD;
                        stacks.Add(stack);
                        stack.Add(container);
                        amountOfStacks++;
                    }
                }
            }
        }








        public void SortAllValuable(List<Container> containers)
        {
            foreach (Container container in containers)
            {
                if (container.IsValuable == true)
                {
                    bool containerAdded = false;
                    foreach (Stack existingStack in stacks)
                    {
                        if (existingStack.TryAddStackRefrigerated() == true)
                        {
                            existingStack.Add(container);
                            containerAdded = true;
                            break;
                        }
                    }
                    if (containerAdded == false)
                    {
                        Stack stack = new Stack();
                        XPositionD++;
                        if (XPositionD == 4)
                        {
                            XPositionD = 1;
                            YPositionD++;
                        }
                        stack.XPosition = XPositionD;
                        stack.YPosition = YPositionD;
                        stacks.Add(stack);
                        stack.Add(container);
                        amountOfStacks++;
                    }
                }
            }
        }




























        

    }
}
