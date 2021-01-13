using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ContainerCollection container = new ContainerCollection();
            container.Add();
            SortingManagement sortingManagement = new SortingManagement();
            Assert.AreEqual("a","a");
        }
    }
}
