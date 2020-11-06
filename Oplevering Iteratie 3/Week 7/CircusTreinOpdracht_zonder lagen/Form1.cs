using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinOpdracht
{
    public partial class Form1 : Form
    {
        Train train = new Train();
        List<Animal> animals = new List<Animal>();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal("Zebra", 3, false));
            animals.Add(new Animal("Leeuw", 3, true));
            animals.Add(new Animal("Muis",1,false));
            animals.Add(new Animal("Olifant", 5, false));
            animals.Add(new Animal("Giraffe", 5, false));
            foreach(Animal animal in animals)
            {
                tbTrain.Text += animal.Name + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            train.SortCarnivore(animals);
            train.SortAnimals(animals);
            int Aantal = 1;
            lbWagon.Items.Add("You need " + train.AmountOfWagons + " wagons.");
            foreach (Wagon wagon in train.GetWagons())
            {
                lbWagon.Items.Add("Wagon " + Aantal);
                foreach (Animal animal in wagon.GetAnimals())
                {
                    lbWagon.Items.Add(animal.Name + animal.Size);
                }
                Aantal++;
                lbWagon.Items.Add("");
            }

        }
    }
}
