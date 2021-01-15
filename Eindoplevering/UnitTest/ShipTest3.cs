using ContainerVervoer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class ShipTest3
    {
        [TestMethod]
        public void Fill_FirstRow_CooledContainersAndValuableContainers_Succes() // Check to always stack valuable on top for first row
        {
            //arrange
            Ship ship = new Ship(2,2,20);
            ContainerCollection containerCollection = new ContainerCollection(2,2);
            Container cc = new Container {Weight = 10 ,IsRefrigerated = true};
            Container cc1 = new Container { Weight = 10, IsRefrigerated = true };
            Container cv = new Container { Weight = 10 , IsValuable=true};
            Container cv2 = new Container { Weight = 10 , IsValuable = true };
            containerCollection.AddCc(cc);
            containerCollection.AddCc(cc1);
            containerCollection.AddCv(cv);
            containerCollection.AddCv(cv2);

            List<Container> cLastRow = new List<Container>();
            cLastRow = ship.ListForFirstRow(containerCollection.GetCc(), containerCollection.GetCv());
            bool bCool = true; //Last Row contains cooled containers
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
