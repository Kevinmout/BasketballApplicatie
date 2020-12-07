using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void SortInWagon_SmallMeatMediumPlantAnimal_1Wagon()
        {
            //Arrange
            Animal animalM = new Animal
            {
                Name = "Kat",
                IsCarnivore = true,
                Size = 1
            };

            Animal animalP = new Animal
            {
                Name = "Geit",
                IsCarnivore = false,
                Size = 3
            };

            //Act
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalM);
            animalCollection.AddAnimal(animalP);
            train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());
            
            
            //Arrange
            Assert.AreEqual(1, train.AmountOfWagons);
        }
    }
}
