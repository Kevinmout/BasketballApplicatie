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
                IsRefrigerated = false,
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

            //Act
            for (int i = 0; i < 5; i++)
            {
                containerCollection.Add(container);
            }
            containerCollection.Add(container1);
            deck.SortRefrigerated(containerCollection.GetContainers());
            deck.SortAllHeavy(containerCollection.GetContainers());
            deck.SortAllLessHeavy(containerCollection.GetContainers());
            deck.SortAllValuable(containerCollection.GetContainers());

            //Assert
            Assert.AreEqual(2, deck.AmountOfStacks);
        }
    }
}
