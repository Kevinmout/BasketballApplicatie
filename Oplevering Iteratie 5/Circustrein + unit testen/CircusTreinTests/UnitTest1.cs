using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTreinTests
{
    [TestClass]
    public class UnitTest1
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
            Assert.AreEqual(1, animalCollection.GetAnimals().Count);
        }
    }
}
