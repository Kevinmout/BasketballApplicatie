using System;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalCollection animalCollection = new AnimalCollection();
            bool Again = true;
            while (Again == true)
            {
                Animal animal = new Animal();
                Console.WriteLine("Give the name of the animal.");
                animal.Name = Console.ReadLine();
                Console.WriteLine("Does the animal eat plants?");
                string YesOrNo = Console.ReadLine().ToUpper();
                bool IsCarnivore;
                if (YesOrNo == "Y" || YesOrNo == "YES")
                {
                    IsCarnivore = false;
                }
                else
                {
                    IsCarnivore = true;
                }
                animal.IsCarnivore = IsCarnivore;
                Console.WriteLine("Is your animal small, medium or large size?");
                string Size = Console.ReadLine().ToUpper();
                int SizeOfAnimal = 0;
                if (Size == "SMALL")
                {
                    SizeOfAnimal = 1;
                }
                else if (Size == "MEDIUM")
                {
                    SizeOfAnimal = 3;
                }
                else if (Size == "LARGE")
                {
                    SizeOfAnimal = 5;
                }
                animal.Size = SizeOfAnimal;
                animalCollection.AddAnimal(animal);
                Console.WriteLine("Do you want to add more animals?");
                string Answer = Console.ReadLine().ToUpper();
                if (Answer == "N" || Answer == "NO")
                {
                    Again = false;
                }
            }
            Train train = new Train();
            //train.SortCarnivore(animalCollection.GetAnimals());
            train.SortAnimals(animalCollection.GetAnimals());
            int Aantal = 1;
            Console.WriteLine("You need " + train.AmountOfWagons + " wagons.");
            foreach (Wagon wagon in train.GetWagons())
            {
                Console.WriteLine("Wagon " + Aantal);
                foreach (Animal animal in wagon.GetAnimals())
                {
                    Console.WriteLine(animal.Name);
                }
                Aantal++;
                Console.WriteLine("");
            }
        }
    }
}
