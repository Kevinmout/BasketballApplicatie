using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
namespace ContainerVervoerTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Container container2 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = true
            };
            Container container = new Container
            {
                Weight = 30,
                IsRefrigerated = true,
                IsValuable = false
            };
            Container container1 = new Container
            {
                Weight = 20,
                IsRefrigerated = false,
                IsValuable = false
            };
            ContainerCollection containerCollection = new ContainerCollection();
            Deck deck = new Deck();
            for (int i = 0; i < 7; i++)
            {
                containerCollection.Add(container);
            }
            containerCollection.Add(container1);
            containerCollection.Add(container2);
            //Act
            
            deck.SortRefrigerated(containerCollection.GetContainers());
            deck.SortAllValuable(containerCollection.GetContainers());
            deck.SortAllHeavy(containerCollection.GetContainers());
            //Assert
            Assert.AreEqual(2, deck.AmountOfStacks);
        }
    }
}
