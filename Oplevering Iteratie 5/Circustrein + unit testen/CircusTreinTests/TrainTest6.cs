using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class TrainTest6
    {
        [TestMethod]
        public void SortInWagon_1BigMeat2BigPlantAnimals_2Wagons()
        {
            //Arrange
            Animal animalMb = new Animal
            {
                Name = "Beer",
                IsCarnivore = true,
                Size = 5
            };
            Animal animalPb1 = new Animal
            {
                Name = "Olifant",
                IsCarnivore = false,
                Size = 5
            };
            Animal animalPb2 = new Animal
            {
                Name = "Giraffe",
                IsCarnivore = false,
                Size = 5
            };
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalMb);
            animalCollection.AddAnimal(animalPb1);
            animalCollection.AddAnimal(animalPb2);
            //Act


            //train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());


            //Arrange
            Assert.AreEqual(2, train.AmountOfWagons);
        }
    }
}
