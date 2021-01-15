using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Check_120TonsNotExceed_130Tons_Error()
        {
            //arrange
            Stack stack = new Stack();
            int weightColumn = 130;


            //act
            stack.CheckColumnWeight(weightColumn);
            
            //assert
            Assert.IsFalse(stack.CheckColumnWeight(weightColumn));
        }
    }
}
