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
            //Arrange
            Container container1 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = false
            };
            Container container2 = new Container
            {
                Weight = 10,
                IsRefrigerated = false,
                IsValuable = false
            };

            ContainerCollection containerCollection = new ContainerCollection();
            for (int i = 0; i < 21; i++)
            {
                containerCollection.Add(container1);
            }
            for (int i = 0; i < 20; i++)
            {
                containerCollection.Add(container2);
            }
            containerCollection.OrderByWeight();
            
            Deck deck = new Deck();
            //Act
            deck.Add(containerCollection.GetContainers(), 5);

            //Assert
            Assert.AreEqual(2, deck.GetRows());
        }
    }
}
