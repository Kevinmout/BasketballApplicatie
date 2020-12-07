using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void SortInWagon_BigMeatBigPlantAnimal_2Wagons()
        {
            //Arrange
            Animal animalM = new Animal
            {
                Name = "Beer",
                IsCarnivore = true,
                Size = 5
            };

            Animal animalP = new Animal
            {
                Name = "Giraffe",
                IsCarnivore = false,
                Size = 5
            };
            
            //Act
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalM);
            animalCollection.AddAnimal(animalP);
            train.SortAnimals(animalCollection.GetAnimals());
            train.SortCarnivore(animalCollection.GetAnimals());
            
            //Arrange
            Assert.AreEqual(2, train.AmountOfWagons);
        }
    }
}
