using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class AnimalCollection
    {
        private List<Animal> animals;
        public List<Animal> GetAnimals()
        {
            return animals;
        }
        public AnimalCollection()
        {
            animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            //animals.Add(new Animal { Name = animal.Name, Size = animal.Size, IsCarnivore = animal.IsCarnivore });
            animals.Add(animal);
        }
    }
}
