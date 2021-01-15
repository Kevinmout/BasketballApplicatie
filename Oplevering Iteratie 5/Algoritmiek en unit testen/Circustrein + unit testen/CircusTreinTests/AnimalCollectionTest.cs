using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CircusTreinTests
{
    [TestClass]
    public class AnimalCollectionTest
    {
        [TestMethod]
        public void Add_AnimalThatEatsPlants_Succes()
        {
            //Arrange
            Animal animal = new Animal
            {
                Name = "Zebra",
                IsCarnivore = false,
                Size = 3
            };
            AnimalCollection animalCollection = new AnimalCollection();
            
            //Act
            animalCollection.AddAnimal(animal);

            //Assert
            foreach(var item in animalCollection.GetAnimals())
            {
                Assert.AreEqual(animal, item);
            }
            Assert.AreEqual(1, animalCollection.GetAnimals().Count);
        }
    }
}
