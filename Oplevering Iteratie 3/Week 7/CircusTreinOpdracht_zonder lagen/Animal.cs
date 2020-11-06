using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinOpdracht
{
    public class Animal
    {
        public string Name { get;}
        public int Size { get;}
        public bool IsCarnivore { get;}

        public Animal(string name, int size, bool isCarnivore)
        {
            Name = name;
            Size = size;
            IsCarnivore = isCarnivore;
        }
    }
}
