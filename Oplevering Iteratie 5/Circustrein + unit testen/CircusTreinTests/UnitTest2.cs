using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Add_AnimalThatEatsMeat_Succes()
        {
            //Arrange
            Animal animal = new Animal
            {
                Name = "Leeuw",
                IsCarnivore = true,
                Size = 3
            };
            AnimalCollection animalCollection = new AnimalCollection();
            
            //Act
            animalCollection.AddAnimal(animal);

            //Assert
            string result = "";
            foreach (Animal animal1 in animalCollection.GetAnimals())
            {
                result = animal1.Name;
            }
            Assert.AreEqual(1, animalCollection.GetAnimals().Count);
            Assert.AreEqual("Leeuw", result);
        }
    }
}
