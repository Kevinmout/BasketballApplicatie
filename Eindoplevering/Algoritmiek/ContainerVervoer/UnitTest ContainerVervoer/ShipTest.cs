using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ShipTest
    {
        [TestMethod]
        public void Check_TotalLoadWeight_Ship20ton_Add_TwoCcContainers_4Ton_False()
        {
            //arrange
            Ship ship = new Ship(2,2,20);
            
            ContainerCollection containerCollection = new ContainerCollection(2,2); //assumption is to add two cooled containers
            Container container = new Container { Weight = 31, IsRefrigerated = true};
            Container container1 = new Container { Weight = 32, IsRefrigerated = true};
            containerCollection.AddCc(container);
            containerCollection.AddCc(container1);

            //act

            ship.CheckLoadWeight(containerCollection.GetCn(),containerCollection.GetCv(),containerCollection.GetCc());
            //assert
            Assert.IsFalse(ship.CheckLoadWeight(containerCollection.GetCn(), containerCollection.GetCv(), containerCollection.GetCc()));
        }
    }
}
