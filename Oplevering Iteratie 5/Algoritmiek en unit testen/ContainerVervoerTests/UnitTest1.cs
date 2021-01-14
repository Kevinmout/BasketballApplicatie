using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
namespace ContainerVervoerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ContainerCollection containerCollection = new ContainerCollection();
            Container container1 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
                for (int i = 0; i < 21; i++)
                {
                    containerCollection.Add(container1);
                }
            //containerCollection.Add(container5);
            //containerCollection.Add(container6);

            containerCollection.OrderByWeight();
            Ship ship = new Ship();
            //Deck deck = new Deck();
            Row row = new Row(4);


            //Act
            row.AddRefrigerated(containerCollection.GetContainers());
            //ship.PlaceContainersOnShip(containerCollection.GetContainers());
            //deck.Add(containerCollection.GetContainers(), 4);

            //Assert
            //Assert.AreEqual(4, row.GetStacks().Count);
            Assert.AreEqual(1, ship);
        }
    }
}
