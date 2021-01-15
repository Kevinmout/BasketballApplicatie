using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class StackTest2
    {
        [TestMethod]
        public void Check_Balance20Percent_40TonsAnd61Tons_Error()
        {
            //arrange
            Stack stack = new Stack();
            double heaviestLoad = 61;
            double lightestLoad = 40;


            //act
            stack.CheckSixtyPercent(heaviestLoad, lightestLoad);
            
            //assert
            Assert.IsFalse(stack.CheckSixtyPercent(heaviestLoad, lightestLoad));
        }
    }
}
