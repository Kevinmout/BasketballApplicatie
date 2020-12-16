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
            Container container = new Container
            {
                Weight = 30,
                IsRefrigerated = true,
                IsValuable = false
            };
            Container container1 = new Container
            {
                Weight = 25,
                IsRefrigerated = false,
                IsValuable = true
            };
            ContainerCollection containerCollection = new ContainerCollection();
            Deck deck = new Deck();
            for (int i = 0; i < 5; i++)
            {
                containerCollection.Add(container);
            }
            containerCollection.Add(container1);
            //Act
            deck.SortRefrigerated(containerCollection.GetContainers());
            deck.SortRefrigerated(containerCollection.GetContainers());
            //Assert
            Assert.AreEqual(2, deck.AmountOfStacks);
        }
    }
}
