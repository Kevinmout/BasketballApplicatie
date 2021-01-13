using System;

namespace ContainerVervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ContainerCollection container = new ContainerCollection();
            container.Add();
            ship.AddRow(container.GetContainers());
            foreach (var item in ship.GetRows())
            {
                foreach (var item1 in item.GetStacks())
                {
                    foreach (var item2 in item1.GetContainers())
                    {
                        Console.WriteLine(item2.Weight);
                    }
                }
            }
            
        }
    }
}
