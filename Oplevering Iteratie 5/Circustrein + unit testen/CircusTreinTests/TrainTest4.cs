using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class TrainTest4
    {
        [TestMethod]
        public void SortInWagon_10SmallPlantAnimals_1Wagon()
        {
            //Arrange
            Animal animal1 = new Animal
            {
                Name = "Rat",
                IsCarnivore = false,
                Size = 1
            };
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            for (int i = 0; i < 10; i++)
            {
                animalCollection.AddAnimal(animal1);
            }
            //Act

            //train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());


            //Arrange
            Assert.AreEqual(1, train.AmountOfWagons);
        }
    }
}
