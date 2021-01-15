using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class ShipTest2
    {
        [TestMethod]
        public void Fill_LastRow_NormalContainersAndValuableContainers_Succes() // Check to always stack valuable on top for last row
        {
            //arrange
            Ship ship = new Ship(2,2,20);
            ContainerCollection containerCollection = new ContainerCollection(2,2);
            Container cn = new Container {Weight = 10 };
            Container cn1 = new Container { Weight = 10 };
            Container cv = new Container { Weight = 10 , IsValuable=true};
            Container cv2 = new Container { Weight = 10 , IsValuable = true };
            containerCollection.AddCn(cn);
            containerCollection.AddCn(cn1);
            containerCollection.AddCv(cv);
            containerCollection.AddCv(cv2);
            List<Container> cLastRow = new List<Container>();
            cLastRow = ship.ListForLastRow(containerCollection.GetCn(), containerCollection.GetCv());
            bool bCool = false; //Last Row doesn't contain cooled containers
            Stack stack = new Stack();

            //act
            ship.AddFirstLastRow(cLastRow,bCool);

            //assert
            foreach (Row row in ship.GetRows())
            {
                row.GetStacks();
                Assert.IsTrue(row.GetStacks().Last().BValuable);
                Assert.IsFalse(row.GetStacks().First().BValuable);
            }
        }
    }
}
