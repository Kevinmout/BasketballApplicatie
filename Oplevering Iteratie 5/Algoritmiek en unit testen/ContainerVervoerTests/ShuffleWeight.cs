using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
using System;

namespace ContainerVervoerTests
{
    [TestClass]
    public class ShuffleWeight
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Row row = new Row(2);
            Stack stack = new Stack();
            Stack stack2 = new Stack();
            Stack stack3 = new Stack();
            stack.Weight = 30;
            stack.IsValuable = false;
            stack2.Weight = 150;
            stack2.IsValuable = false;
            stack3.Weight = 150;
            stack3.IsValuable = false;
            row.GetStacks().Add(stack);
            row.GetStacks().Add(stack2);
            row.GetStacks().Add(stack3);

            //Act
            row.SortWeightStacks();
            //row.SortWeightStacks();
            //Assert
            Assert.AreEqual(5,row.GetStacks().Count);
        }
    }
}
