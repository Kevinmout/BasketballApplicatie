using Auto.Logic;
using Auto.Logic.Interfaces;
using System;
using System.Collections.Generic;

namespace AutoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            ICar car1 = car;
            car1.CarSound();
        }
    }
}
