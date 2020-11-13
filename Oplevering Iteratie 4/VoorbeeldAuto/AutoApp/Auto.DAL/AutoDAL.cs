using Auto.Logic.Interfaces;
using System.Collections.Generic;
using Auto.Logic;

namespace Auto.DAL
{
    public class AutoDAL : ICar
    {
        private List<Car> _autos;
        public AutoDAL()
        {
            _autos = new List<Car>()
            {
                new Car(){Merk = "BMW", Prijs = 100000},
                new Car(){Merk = "Renault", Prijs = 10000},
                new Car(){Merk = "Mercedes", Prijs = 200000}
            };
        }

        public void CarSound()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Car> getCars()
        {
            return _autos;
        }
    }
}
