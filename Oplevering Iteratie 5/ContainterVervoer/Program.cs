using System;

namespace ContainterVervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContainerCollection containerCollection = new ContainerCollection();
            Container container = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            Container container1 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            Container container2 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            Container container3 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            containerCollection.Add(container);
            containerCollection.Add(container1);
            containerCollection.Add(container2);
            containerCollection.Add(container3);

            Deck deck = new Deck();
            deck.SortRefrigerated(containerCollection.GetContainers());
            //deck.SortAllHeavy(containerCollection.GetContainers());
            
            foreach (Stack stack in deck.GetStacks())
            {
                Console.WriteLine("Een Stack");
                foreach (Container containerOnstack in stack.GetContainers())
                {
                    Console.WriteLine(containerOnstack.Weight);
                }
            }
            Console.ReadLine();
        }
    }
}
