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
            ContainerCollection containerCollection = new ContainerCollection();
            Container container1 = new Container()
            {
                Weight = 10
            };
            Container container2 = new Container()
            {
                Weight = 20
            };
            Container container3 = new Container()
            {
                Weight = 30
            };
            Container container4 = new Container()
            {
                Weight = 40
            };
            Container container5 = new Container()
            {
                Weight = 50
            };
            Container container6 = new Container()
            {
                Weight = 60
            };

            containerCollection.Add(container1);
            containerCollection.Add(container2);
            containerCollection.Add(container3);
            containerCollection.Add(container4);
            containerCollection.Add(container5);
            containerCollection.Add(container6);
            //Act
            

            //Assert
            //Assert.AreEqual();
        }
    }
}
