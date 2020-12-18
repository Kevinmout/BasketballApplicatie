using System;
using System.Linq;

namespace ContainterVervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContainerCollection containerCollection = new ContainerCollection();

            Deck deck = new Deck();
            Container container = new Container
            {
                Weight = 50,
                IsRefrigerated = true,
                IsValuable = false
            };
            containerCollection.Add(container);
            containerCollection.OrderByWeight();



        }
    }
}
