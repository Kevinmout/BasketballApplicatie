using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class TrainTest3
    {
        [TestMethod]
        public void SortInWagon_2BigPlantAnimal_1WagonWithGoodAnimals()
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
            //train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());


            //Arrange
            CollectionAssert.AreEqual(animalCollection.GetAnimals(), new[] { animalM, animalP });
            var actualGirafe = animalCollection.GetAnimals()
                .Where(animal => animal.Name.StartsWith("G"));

            Animal actualGiraffe = null;
            foreach (var animal in animalCollection.GetAnimals())
            {
                if (animal.Name == "Giraffe")
                {
                    actualGiraffe = animal;
                    break;
                }
            }

            Assert.IsNotNull(actualGiraffe);
            Assert.IsFalse(actualGiraffe.IsCarnivore);
            Assert.AreEqual(5, actualGiraffe.Size);
        }
    }
}
