using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class WagonTest2
    {
        [TestMethod]
        public void SortInWagon_MediumMeatMediumPlantAnimal_2Wagons()
        {
            //Arrange
            Animal animal = new Animal
            {
                Name = "Leeuw",
                IsCarnivore = true,
                Size = 3
            };
            Animal animal1 = new Animal
            {
                Name = "Geit",
                IsCarnivore = false,
                Size = 3
            };
            AnimalCollection animalCollection = new AnimalCollection();
            animalCollection.AddAnimal(animal);
            animalCollection.AddAnimal(animal1);
            Train train = new Train();

            //Act
            train.SortAllAnimals(animalCollection.GetAnimals());
            //Assert
            Assert.AreEqual(2, train.GetWagons().Count);
        }
    }
}

