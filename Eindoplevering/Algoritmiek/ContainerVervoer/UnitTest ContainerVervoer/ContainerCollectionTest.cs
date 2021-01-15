using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ContainerCollectionTest
    {
        [TestMethod]
        public void Add_2CooledContainers_LessThan4tons_Error()
        {
            //arrange
            ContainerCollection containerCollection = new ContainerCollection(2,2); //assumption is to add two cooled containers
            Container container = new Container { Weight = 1, IsRefrigerated = true };
            Container container1 = new Container { Weight = 2, IsRefrigerated = true };
            
            //act
            containerCollection.AddCc(container);
            containerCollection.AddCc(container1);

            //assert
            Assert.AreEqual(0,containerCollection.GetCc().Count);
        }
    }
}
