using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class WagonTest4
    {
        [TestMethod]
        public void CheckOccupation_AddAnimal_Size5_WhereOccupationIs10_False()
        {
            //Arrange
            Wagon wagon = new Wagon();
            //wagon.Occupation = 10;
            Animal animal = new Animal
            {
                Size = 5
            };


            //Act
            wagon.TryAddAnimalOccupation(animal);
            
            //Assert
            Assert.AreEqual(false, wagon.TryAddAnimalOccupation(animal));
        }
    }
}
