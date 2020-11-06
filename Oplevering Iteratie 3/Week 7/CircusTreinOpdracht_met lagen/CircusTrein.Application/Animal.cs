using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein.Application
{
    public class Animal
    {
        public string Name { get; }
        public int Size { get; }
        public bool IsCarnivore { get; }

        public Animal(string name, int size, bool isCarnivore)
        {
            Name = name;
            Size = size;
            IsCarnivore = isCarnivore;
        }
    }
}
