using CircusTrein.Persistence;
using CircusTrein.Persistence.Interface.Interfaces;
using System;

namespace CircusTrein.DalFactory
{
    public static class AnimalFactory
    {
        public static IAnimalDal GetAnimalDal()
        {
            return new AnimalDal(); 
        }
    }
}
