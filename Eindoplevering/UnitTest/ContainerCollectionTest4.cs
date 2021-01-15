using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ContainerCollectionTest4
    {
        [TestMethod]
        public void Add_2ValuableContainers_MoreThan30tons_Error()
        {
            //arrange
            ContainerCollection containerCollection = new ContainerCollection(2,2); //assumption is to add two cooled containers
            Container container = new Container { Weight = 31, IsValuable = true};
            Container container1 = new Container { Weight = 32, IsValuable = true };
            
            //act
            containerCollection.AddCv(container);
            containerCollection.AddCv(container1);

            //assert
            Assert.AreEqual(0,containerCollection.GetCc().Count);
        }
    }
}
