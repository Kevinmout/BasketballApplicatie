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
                IsRefrigerated = true,
                IsValuable = false
            };
            
            Container container5 = new Container
            {
                Weight = 30,
                IsRefrigerated = false,
                IsValuable = true
            };
            Container container6 = new Container
            {
                Weight = 20,
                IsRefrigerated = false,
                IsValuable = true
            };

            ContainerCollection containerCollection = new ContainerCollection();
            containerCollection.Add(container1);
            containerCollection.Add(container1);
            containerCollection.Add(container1);
            containerCollection.Add(container1);
            containerCollection.Add(container5);
            containerCollection.Add(container6);
            containerCollection.OrderByWeight();
            //Deck deck = new Deck();
            Row row = new Row();

            //Act
            row.AddRefrigerated(containerCollection.GetContainers());

            //Assert
            Assert.AreEqual(4, row.GetStacks().Count);
        }
    }
}
