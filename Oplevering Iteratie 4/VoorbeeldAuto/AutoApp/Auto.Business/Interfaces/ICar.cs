using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Logic.Interfaces
{
    public interface ICar
    {
        IEnumerable<Car> GetCars();
    }
}
