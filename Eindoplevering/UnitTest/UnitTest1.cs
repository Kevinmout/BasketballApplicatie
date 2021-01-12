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
            SortingManagement sortingManagement = new SortingManagement();
            //sortingManagement.LessThan120Tons();
            Assert.AreEqual("a","a");
        }
    }
}
