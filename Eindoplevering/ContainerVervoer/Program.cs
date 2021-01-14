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
            //ship.ListForLastRow(ship.CheckDivisibleByWidth(container.GetContainers()));
            //ship.AddLastRow((ship.CheckDivisibleByWidth(container.GetContainers())));
            ship.AddRow(ship.CheckDivisibleByWidth(container.GetContainers()));
            ////functions in ship
            //ship.CheckWidthEvenOrUneven();
            //















            foreach (var item in ship.GetRows())
            {
                Console.WriteLine("Row:");
                foreach (var item1 in item.GetStacks())
                {
                    Console.WriteLine("------");
                    foreach (var item2 in item1.GetContainers())
                    {
                        Console.WriteLine(item2.Weight);
                    }
                }
            }

        }
    }
}
