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
        public int AmountOfStacks
        {
            get { return amountOfStacks; }
            set { amountOfStacks = AmountOfStacks; }
        }

        private int amountOfStacks;

        public Deck()
        {
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
                        stacks.Add(stack);
                        stack.Add(container);
                        amountOfStacks++;
                    }
                }
            }
        }




























        

    }
}
