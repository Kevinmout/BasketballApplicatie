using Auto.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Logic
{
    public class Car : ICar
    {
        public string Merk { get; set; }
        public int Prijs { get; set; }
        public void CarSound()
        {
            Console.WriteLine("Vroom");
        }

        public void Drive()
        {
            Console.WriteLine("Put foot on gaspedal.");
        }
    }
}
