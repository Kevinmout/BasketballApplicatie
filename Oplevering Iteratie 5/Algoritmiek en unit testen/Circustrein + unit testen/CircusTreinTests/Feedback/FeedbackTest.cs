using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class FeedbackTest // Timo feedback: Prachtige naaam <3 (groepeer per class)
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
                Size = 3 //--> enums (Misschien eens checken ;) www.lmgtfy.com?q=c#enums )
            };
            AnimalCollection animalCollection = new AnimalCollection();
            Train train = new Train();
            animalCollection.AddAnimal(animalM);
            animalCollection.AddAnimal(animalP);

            //Act // Timo feedback: Act is altijd maar 1 methode :)
            //train.SortAnimals(animalCollection.GetAnimals()); // Timo feedback alternatief: Moet de buitenwereld weten dat je altijd eerst de herbivores doet sorten en daarna de carnivoren? :D
            //train.SortCarnivore(animalCollection.GetAnimals()); // Timo feedback : Deze acties doe je waarschijnlijk in 1 methode? :D


            //Arrange
            Assert.AreEqual(1, train.AmountOfWagons);
        }
    }
}
