using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ContainerCollectionTest3
    {
        [TestMethod]
        public void Add_2NormalContainers_MoreThan30tons_Error()
        {
            //arrange
            ContainerCollection containerCollection = new ContainerCollection(2,2); //assumption is to add two cooled containers
            Container container = new Container { Weight = 31 };
            Container container1 = new Container { Weight = 32 };
            
            //act
            containerCollection.AddCn(container);
            containerCollection.AddCn(container1);

            //assert
            Assert.AreEqual(0,containerCollection.GetCc().Count);
        }
    }
}
