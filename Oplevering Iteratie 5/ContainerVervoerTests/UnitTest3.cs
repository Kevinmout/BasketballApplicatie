using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainterVervoer;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoerTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ContainerCollection containerCollection = new ContainerCollection();
            Deck deck = new Deck();
            Container container = new Container
            {
                IsRefrigerated = true,
                IsValuable = false,
                Weight = 30
            };
            Container container1 = new Container
            {
                IsRefrigerated = false,
                IsValuable = false,
                Weight = 30
            };
            Container container2 = new Container
            {
                IsRefrigerated = false,
                IsValuable = true,
                Weight = 30
            };
            for (int i = 0; i < 18; i++)
            {
                containerCollection.Add(container);
            }
            
            for (int i = 0; i < 4; i++)
            {
                containerCollection.Add(container2);
            }
            for (int i = 0; i< 18; i++)
            {
                containerCollection.Add(container1);
            }
            
            //act
            deck.SortRefrigerated(containerCollection.GetContainers());
            deck.SortAllHeavy(containerCollection.GetContainers());
            deck.SortAllValuable(containerCollection.GetContainers());
            //Assert
            Assert.AreEqual(8, deck.AmountOfStacks);
        }
    }
}
