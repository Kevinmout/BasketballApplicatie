using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void SortInWagon_1SmallMeat1Small2MediumPlantAnimals_2Wagons()
        {
            //Arrange
            Animal animalMs = new Animal
            {
                Name = "Libel",
                IsCarnivore = true,
                Size = 1
            };
            Animal animalPs = new Animal
            {
                Name = "Mier",
                IsCarnivore = false,
                Size = 1
            };
            Animal animalPm1 = new Animal
            {
                Name = "Geit",
                IsCarnivore = false,
                Size = 3
            };
            Animal animalPm2 = new Animal
            {
                Name = "Schaap",
                IsCarnivore = false,
                Size = 3
            };
            //Act
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalMs);
            animalCollection.AddAnimal(animalPs);
            animalCollection.AddAnimal(animalPm1);
            animalCollection.AddAnimal(animalPm2);

            train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());


            //Arrange
            Assert.AreEqual(2, train.AmountOfWagons);
        }
    }
}
