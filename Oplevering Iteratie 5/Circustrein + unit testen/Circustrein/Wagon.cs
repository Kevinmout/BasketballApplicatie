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


        /// <summary>
        /// Checks if there's enough space left for the selected animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>True or false</returns>
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

        /// <summary>
        /// Checks if there's not going to be a foodchain problem by adding the selected animal
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>True or false</returns>
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

        /// <summary>
        /// Checks if there's no carnivore in the wagon
        /// </summary>
        /// <returns>True or false</returns>
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

        /// <summary>
        /// Adds animal to the wagon
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            animalsInWagon.Add(animal);
            occupation += animal.Size;
        }

    }
}
