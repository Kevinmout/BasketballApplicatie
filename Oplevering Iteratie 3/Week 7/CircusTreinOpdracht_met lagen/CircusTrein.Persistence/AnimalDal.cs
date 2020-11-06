using System;
using CircusTrein.Persistence.Interface.Interfaces;
using CircusTrein.Persistence.Interface.Dtos;

namespace CircusTrein.Persistence
{
    public class AnimalDal : IAnimalDal
    {
        public AnimalDto GetById(int id)
        {
            return new AnimalDto
            {
                Name = "Zebra",
                Size = 3,
                IsCarnivore = false
            };
        }

        public void Add(AnimalDto animal)
        {
            //
        }
    }
}
