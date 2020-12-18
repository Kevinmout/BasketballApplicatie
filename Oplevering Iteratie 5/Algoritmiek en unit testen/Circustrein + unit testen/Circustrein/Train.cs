using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> wagons;
        public int AmountOfWagons
        {
            get { return amountOfWagons; }
            set { amountOfWagons = AmountOfWagons; }
        }
        private int amountOfWagons;

        public Train()
        {
            wagons = new List<Wagon>();
        }


        public List<Wagon> GetWagons()
        {
            return wagons;
        }


        public void AddWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagons.Add(wagon);
            wagon.AddAnimal(animal);
            amountOfWagons++;
        }

        public void SortAllAnimals(List<Animal> allAnimals)
        {
            SortCarnivore(allAnimals);
            SortHerbivore(allAnimals);
        }

        public void SortCarnivore(List<Animal> allAnimals)
        {
            foreach (Animal animal in allAnimals)
            {
                if (animal.IsCarnivore == true)
                {
                    AddWagon(animal);
                }
            }
        }



        public void SortHerbivore(List<Animal> allAnimals)
        {
            foreach (Animal animal in allAnimals)
            {
                if (animal.IsCarnivore == false)
                {

                    if (TryAddExistingWagon(animal) == false)
                    {
                        AddWagon(animal);
                    }

                }
            }
        }

        public bool TryAddExistingWagon(Animal animal)
        {
            bool animalAdded = false;
            foreach (Wagon existingWagon in wagons)
            {
                if (existingWagon.TryAddAnimalSizeHerbivore() == true && existingWagon.TryAddAnimalOccupation(animal) == true)
                {
                    animalAdded = true;
                    existingWagon.AddAnimal(animal);
                    break;
                }
                else if (existingWagon.TryAddAnimalOccupation(animal) == true && existingWagon.TryAddAnimalCarnivoreSize(animal) == true)
                {
                    animalAdded = true;
                    existingWagon.AddAnimal(animal);
                    break;
                }
            }
            return animalAdded;
        }
    }
}