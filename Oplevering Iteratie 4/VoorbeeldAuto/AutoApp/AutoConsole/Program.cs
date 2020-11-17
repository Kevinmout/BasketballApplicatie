using Auto.Logic;
using Auto.Logic.Interfaces;
using Player.Dal;
using System;
using System.Collections.Generic;

namespace AutoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPlayer obj = new PlayersDal();
            obj.GetPlayers();
            foreach(var item in obj.GetPlayers())
            {
                Console.WriteLine(item.FirstName); 
            }
        }
    }
}
