using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ContainerCollectionTest2
    {
        [TestMethod]
        public void Add_2CooledContainers_MoreThan30tons_Error()
        {
            //arrange
            ContainerCollection containerCollection = new ContainerCollection(2,2); //assumption is to add two cooled containers
            Container container = new Container { Weight = 31, IsRefrigerated = true };
            Container container1 = new Container { Weight = 32, IsRefrigerated = true };
            
            //act
            containerCollection.AddCc(container);
            containerCollection.AddCc(container1);

            //assert
            Assert.AreEqual(0,containerCollection.GetCc().Count);
        }
    }
}
