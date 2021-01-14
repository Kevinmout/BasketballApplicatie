using System;

namespace ContainerVervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ContainerCollection container = new ContainerCollection(ship.Width, ship.Height);
            container.AddCn();
            container.AddCc();
            container.AddCv();
            ship.CheckWidthEvenOrUneven();
            //ship.AddLastRow(ship.ListForFirstRow(container.GetCc(), container.GetCv()));
            ship.AddFirstLastRow(ship.ListForLastRow(container.GetCn(),container.GetCv()));

            //ship.AddRow(ship.CheckDivisibleByWidth(container.GetContainers()));
            ////functions in ship
            
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
