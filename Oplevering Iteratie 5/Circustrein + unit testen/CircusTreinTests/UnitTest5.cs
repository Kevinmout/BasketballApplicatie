using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void SortInWagon_2BigPlantAnimal_1Wagon()
        {
            //Arrange
            Animal animalM = new Animal
            {
                Name = "Giraffe",
                IsCarnivore = false,
                Size = 5
            };

            Animal animalP = new Animal
            {
                Name = "Olifant",
                IsCarnivore = false,
                Size = 5
            };

            //Act
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalM);
            animalCollection.AddAnimal(animalP);
            train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());


            //Arrange
            CollectionAssert.AreEqual(animalCollection.GetAnimals(), new[] { animalM, animalP });
        }
    }
}
