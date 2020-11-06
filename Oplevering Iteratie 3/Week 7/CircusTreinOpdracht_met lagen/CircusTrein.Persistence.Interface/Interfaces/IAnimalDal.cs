using System;
using System.Collections.Generic;
using System.Text;
using CircusTrein.Persistence.Interface.Dtos;
using CircusTrein.Persistence.Interface.Interfaces;

namespace CircusTrein.Persistence.Interface.Interfaces
{
    public interface IAnimalDal
    {
        AnimalDto GetById(int id);

        void Add(AnimalDto animal);
    }
}
