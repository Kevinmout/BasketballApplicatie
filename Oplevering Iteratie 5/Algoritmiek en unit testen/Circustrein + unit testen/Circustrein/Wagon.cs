using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        private List<Animal> animalsInWagon;
        public int Occupation
        {
            get { return occupation; }
            set { occupation = Occupation; }
        }
        private int occupation;

        public Wagon()
        {
            animalsInWagon = new List<Animal>();
        }


        public List<Animal> GetAnimals()
        {
            return animalsInWagon;
        }


        public bool TryAddAnimalOccupation(Animal animal)
        {
            if (10 >= animal.Size + occupation)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public bool TryAddAnimalCarnivoreSize(Animal animal)
        {
            foreach (Animal animal1 in animalsInWagon)
            {
                if (animal1.IsCarnivore == true && animal.Size > animal1.Size)
                {
                    return true;
                }
            }
            return false;
        }


        public bool TryAddAnimalSizeHerbivore()
        {
            bool AllHerbivore = true;
            foreach (Animal animal1 in animalsInWagon)
            {
                if (animal1.IsCarnivore == true)
                {
                    AllHerbivore = false;
                }
            }
            return AllHerbivore;
        }


        public void AddAnimal(Animal animal)
        {
            animalsInWagon.Add(animal);
            occupation += animal.Size;
        }

    }
}