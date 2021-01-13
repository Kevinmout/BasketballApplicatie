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



        public List<Container> LeftContainers { get; set; }
        public List<Container> RightContainers { get; set; }
        public int[] SortingArray { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }







        public Row(List<Container> containers)
        {
            Width = 6;
            Height = 4;
            SortingArray = new int[Width];
            RightContainers = new List<Container>();
            LeftContainers = new List<Container>();
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
            CreateStack();
        }

        public void CreateStack()
        {
            Stack stack = new Stack();
            stack.FillTemp(SortingArray);
        }



        


        public void GetRow(Row row)
        {
            TryAddContainersOnStack(row);
        }






        public void TryAddContainersOnStack(Row row)
        {
            if (CheckHeight(row) == true && Check120Tons(row) == true)
            {
                //place on existing stack
            }
            else
            {
                //place on new row
            }
        }

        public bool CheckHeight()
        {
            return (Height >= (containersOnStack.Count / Width + 1));
        }


        public bool Check120Tons()
        {
            AddContainersToTempStack();
            int weightColumn = 0;
            bool stackOnTop = true;
            int i = 0;
            while (stackOnTop == true && i < Width)
            {
                for (int j = i; j < Width * Height - Width; j += Width)
                {
                    weightColumn = +containersOnStack.ElementAt(j).Weight;
                }
                stackOnTop = CheckColumnWeight(weightColumn);
                i++;
            }
            return stackOnTop;
        }


        public bool CheckColumnWeight(int weight)
        {
            return (weight > 120);
        }


        public void AddContainersToTempStack()
        {
            foreach (var item in LeftContainers)
            {
                containersOnStack.Add(item);
            }
            foreach (var item in RightContainers)
            {
                containersOnStack.Add(item);
            }
        }






        public void ErrorHandler(string error)
        {
            Console.WriteLine(error);
        }

































































        //public int RowIndex { get; set; }

        //public Row(int rowIndex)
        //{
        //    RowIndex = rowIndex;
        //    stacksInRow = new List<Stack>();
        //    for (int i = 0; i < rowIndex; i++)
        //    {
        //        Stack stack = new Stack();
        //        stack.XPosition = i + 1;
        //        stacksInRow.Add(stack);
        //    }
        //}



        ///// <summary>
        ///// Pick the stack with the lowest amount of containers
        ///// </summary>
        ///// <returns>stack</returns>
        //public Stack ChooseStack()
        //{
        //    int lowest = int.MaxValue;
        //    Stack stack = new Stack();
        //    foreach (Stack ExistingStack in stacksInRow)
        //    {
        //        if (ExistingStack.GetContainers().Count <= lowest)
        //        {
        //            lowest = ExistingStack.GetContainers().Count;
        //            stack = ExistingStack;
        //        }
        //    }
        //    return stack;
        //}




        ///// <summary>
        ///// Add container to a existing stack
        ///// </summary>
        ///// <param name="container"></param>
        //public void AddToExistingStack(Container container, List<Container> containers)
        //{
        //    if (ChooseStack().SortContainer(container) == true)
        //    {
        //        ChooseStack().Add(container);
        //        containers.Remove(container);
        //    }
        //}


        ///// <summary>
        ///// Add refrigerated containers
        ///// </summary>
        ///// <param name="containers"></param>
        //public void AddRefrigerated(List<Container> containers)
        //{
        //    foreach (Container container in containers.ToList())
        //    {
        //        if (container.IsRefrigerated == true)
        //        {
        //            AddToExistingStack(container,containers);

        //        }
        //    }
        //    AddNormal(containers);
        //}


        ///// <summary>
        ///// Add containers to a stack that isn't valuable nor refrigerated
        ///// </summary>
        ///// <param name="containers"></param>
        //public void AddNormal(List<Container> containers)
        //{
        //    foreach (Container container in containers.ToList())
        //    {
        //        if (container.IsRefrigerated == false && container.IsValuable == false)
        //        {
        //            AddToExistingStack(container,containers);
        //        }
        //    }
        //    AddValuable(containers);
        //}



        ///// <summary>
        ///// Add valuable container to a stack
        ///// </summary>
        ///// <param name="containers"></param>
        //public void AddValuable(List<Container> containers)
        //{
        //    foreach (Container container in containers.ToList())
        //    {
        //        if (container.IsValuable == true)
        //        {
        //            AddAtTheTop(container,containers);
        //        }
        //    }
        //    SortWeightStacks();
        //}



        ///// <summary>
        ///// Add valuable container on top of other containers
        ///// </summary>
        ///// <param name="container"></param>
        //public void AddAtTheTop(Container container, List<Container> containers)
        //{
        //    foreach (Stack ExistingStack in stacksInRow)
        //    {
        //        if (ExistingStack.SortContainer(container) == true)
        //        {
        //            ExistingStack.Add(container);
        //            containers.Remove(container);
        //        }
        //    }
        //}



        ///// <summary>
        ///// Sort the stacks, that the weight is good.
        ///// </summary>
        //public List<Stack> SortWeightStacks()
        //{
        //    List<Stack> a = new List<Stack>();
        //    List<Stack> b = new List<Stack>();
        //    double length = Convert.ToDouble(stacksInRow.Count);
        //    for (int i = 0; i < Math.Ceiling(length / 2); i++)
        //    {
        //        a.Add(stacksInRow.ElementAt(i));
        //    }

        //    int remainding = Convert.ToInt32(Math.Ceiling(length / 2));
        //    for (int i = remainding; i < length; i++)
        //    {
        //        b.Add(stacksInRow.ElementAt(i));
        //    }


        //    if (a.Sum(item => item.Weight) > b.Sum(item => item.Weight))
        //    {
        //        a = a.OrderBy(w => w.Weight).ToList();
        //        b = b.OrderBy(w => w.Weight).ToList();
        //        List<Stack> temp = new List<Stack>();

        //        for (int item = 0; item < a.Count; item++)
        //        {
        //            temp.Add(a.ElementAt(item));
        //        }
        //        int i = 0;
        //        while (((b.Sum(item => item.Weight)) <= (temp.Sum(item => item.Weight))) && (i <= a.Count))
        //        {
        //            b.Add(a[i]);
        //            temp.Remove(a.ElementAt(i));
        //            i += 1;
        //        }

        //        a = temp;
        //    }





        //    if (b.Sum(item => item.Weight) > a.Sum(item => item.Weight))
        //    {
        //        a = a.OrderBy(w => w.Weight).ToList();
        //        b = b.OrderBy(w => w.Weight).ToList();
        //        List<Stack> temp = new List<Stack>();
        //        for (int item = 0; item < b.Count; item++)
        //        {
        //            temp.Add(b.ElementAt(item));
        //        }
        //        int i = 0;
        //        while ((a.Sum(item => item.Weight) <= temp.Sum(item => item.Weight)) && (i <= b.Count))
        //        {
        //            a.Add(b[i]);
        //            temp.Remove(b.ElementAt(i));
        //            i += 1;
        //        }
        //        b = temp;
        //    }
        //    stacksInRow.Clear();
        //    foreach (Stack stack in a)
        //    {
        //        stacksInRow.Add(stack);
        //    }
        //    foreach (Stack stack in b)
        //    {
        //        stacksInRow.Add(stack);
        //    }
        //    return stacksInRow;
        //}



    }
}
