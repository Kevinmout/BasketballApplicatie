using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
namespace ContainerVervoerTests
{
    [TestClass]
    public class ContainerWeightTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Container container1 = new Container
            {
                Weight = 35,
                IsRefrigerated = false,
                IsValuable = false
            };

            ContainerCollection containerCollection = new ContainerCollection();
            containerCollection.Add(container1);
            containerCollection.OrderByWeight();
            Ship ship = new Ship();


            //Act
            ship.PlaceContainersOnShip(containerCollection.GetContainers(), 1);
            //Assert
            Assert.AreEqual(0, containerCollection.GetContainers().Count);
        }
    }
}
