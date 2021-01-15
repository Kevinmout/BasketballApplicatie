using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class StackTest3
    {
        [TestMethod]
        public void Check_Balance20Percent_40TonsAnd60Tons_Succes()
        {
            //arrange
            Stack stack = new Stack();
            double heaviestLoad = 60;
            double lightestLoad = 40;


            //act
            stack.CheckSixtyPercent(heaviestLoad, lightestLoad);
            
            //assert
            Assert.IsTrue(stack.CheckSixtyPercent(heaviestLoad, lightestLoad));
        }
    }
}
