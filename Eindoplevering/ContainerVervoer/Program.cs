using System;

namespace ContainerVervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the ship width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the ship height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the ship weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            Ship ship = new Ship(width, height, weight);





            ContainerCollection containerCollection = new ContainerCollection(width, height);
            Container container = new Container()
            {
                Weight = 16
            };


            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCn(container);
            containerCollection.AddCc();
            containerCollection.AddCv();

            //check total weight of containers is bigger than 50% or equal to the weight of the ship
            ship.CheckLoadWeight(containerCollection.GetCn(), containerCollection.GetCv(), containerCollection.GetCc());

            //check if the width is even or uneven
            ship.CheckWidthEvenOrUneven();
            //Add the cooled containers in first row
            ship.AddFirstLastRow(ship.ListForFirstRow(containerCollection.GetCc(), containerCollection.GetCv()));

            ship.CheckDivisibleByWidth(containerCollection.GetCn());
            ship.AddRow(containerCollection.GetCn());

            //Add the last row.
            ship.AddFirstLastRow(ship.ListForLastRow(containerCollection.GetCn(),containerCollection.GetCv()));




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
