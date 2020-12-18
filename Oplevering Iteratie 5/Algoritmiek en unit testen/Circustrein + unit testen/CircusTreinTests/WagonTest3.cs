using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class WagonTest3
    {
        [TestMethod]
        public void SortInWagon_5LargePlantAnimals_3Wagons()
        {
            //Arrange
            Animal animal = new Animal
            {
                Name = "Giraffe",
                IsCarnivore = false,
                Size = 5
            };
            AnimalCollection animalCollection = new AnimalCollection();
            for (int i = 0; i < 5; i++)
            {
                animalCollection.AddAnimal(animal);
            }
            Train train = new Train();

            //Act
            train.SortAllAnimals(animalCollection.GetAnimals());
            //Assert
            Assert.AreEqual(3, train.GetWagons().Count);
        }
    }
}
