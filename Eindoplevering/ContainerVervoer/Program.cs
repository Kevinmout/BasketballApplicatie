using System;
using System.Collections.Generic;

namespace ContainerVervoer
{
    class Program
    {

        static void Main(string[] args)
        {


            Ship ship = new Ship(2,2,1);

            ErrorHandlerClass check = new ErrorHandlerClass();
            ContainerCollection containerCollection = new ContainerCollection(2,2);

            Container container1 = new Container
            {
                Weight = 6,
                IsValuable = true
            };

            Container container2 = new Container
            {
                Weight = 6,
                IsRefrigerated = true
            };


            Container container3 = new Container
            {
                Weight = 8
            };

            for (int i = 0; i < 4; i++)
            {
                containerCollection.AddCv(container1);
            }

            for (int i = 0; i < 2; i++)
            {
                containerCollection.AddCc(container2);
            }


            for (int i = 0; i < 8; i++)
            {
                containerCollection.AddCn(container3);
            }
            

            if (containerCollection.GetCc().Count != 0 && containerCollection.GetCn().Count != 0 && containerCollection.GetCv().Count != 0)
            {
                //check total weight of containers is bigger than 50% or equal to the weight of the ship
                if (ship.CheckLoadWeight(containerCollection.GetCn(), containerCollection.GetCv(), containerCollection.GetCc()) == true)
                {
                    //check if the width is even or uneven
                    ship.CheckWidthEvenOrUneven();

                    //Add the last row.
                    ship.CheckDivisibleByWidth(containerCollection.GetCn());
                    List<Container> normalContainersLeft = ship.AddFirstLastRow(ship.ListForLastRow(containerCollection.GetCn(), containerCollection.GetCv()), true);

                    // middle row
                    ship.CheckDivisibleByWidth(containerCollection.GetCn());
                    ship.AddRowBetweenFirstAndLast(normalContainersLeft);

                    //Add the cooled containers in first row
                    ship.AddFirstLastRow(ship.ListForFirstRow(containerCollection.GetCc(), containerCollection.GetCv()), false);

                    Console.WriteLine("End of the ship");
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
                    Console.WriteLine("Front of the ship");
                }
                else
                {
                    check.ErrorHandler("The total weight of the containers is not heavy enough");
                }


            }
            else
            {
                check.ErrorHandler("Not all containers are given.");
            }
        }





    }
}
