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
            //Act
            
            deck.SortRefrigerated(containerCollection.GetContainers());
            deck.SortAllLessHeavy(containerCollection.GetContainers());
            deck.GetStacks();
            //Assert
            Assert.AreEqual(3, deck.GetStacks());
        }
    }
}
