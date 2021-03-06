﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinOpdracht
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




        /// <summary>
        /// Puts all the carnivores in separate wagons.
        /// </summary>
        /// <param name="allAnimals"></param>
        public void SortCarnivore(List<Animal> allAnimals)
        {
            foreach (Animal animal in allAnimals)
            {
                if (animal.IsCarnivore == true)
                {
                    Wagon wagon = new Wagon();
                    wagons.Add(wagon);
                    wagon.AddAnimal(animal);
                    amountOfWagons++;
                }
            }
        }


        /// <summary>
        /// Puts all the herbivores in wagons.
        /// </summary>
        /// <param name="allAnimals"></param>
        public void SortAnimals(List<Animal> allAnimals)
        {
            foreach (Animal animal in allAnimals)
            {
                if (animal.IsCarnivore == false)
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
                    if (animalAdded == false)
                    {
                        Wagon wagon = new Wagon();
                        wagons.Add(wagon);
                        wagon.AddAnimal(animal);
                        amountOfWagons++;
                    }

                }
            }
        }
    }
}
