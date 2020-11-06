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
            /*
            int size;
            if (rbGroot.Checked == true)
            {
                size = Convert.ToInt32(rbGroot.Tag);
            }
            else if (rbMiddelgroot.Checked == true)
            {
                size = Convert.ToInt32(rbMiddelgroot.Tag);
            }
            else
            {
                size = Convert.ToInt32(rbKlein.Tag);
            }
            tbTrain.Text += tbName.Text + "\r\n";
            animals.Add(new Animal { Name = tbName.Text, Size = size, IsCarnivore = cbCarnivoor.Checked });
            
            animals.Add(new Animal { Name = "Zebra", Size = 3, IsCarnivore = false });
            animals.Add(new Animal { Name = "Leeuw", Size = 3, IsCarnivore = true });
            animals.Add(new Animal { Name = "Muis", Size = 1, IsCarnivore = false });
            animals.Add(new Animal { Name = "Olifant", Size = 5, IsCarnivore = false });
            animals.Add(new Animal { Name = "Giraffe", Size = 5, IsCarnivore = false });
            */
            animals.Add(new Animal("Zebra", 3, false));
            animals.Add(new Animal("Leeuw", 3, true));
            animals.Add(new Animal("Muis",1,false));
            animals.Add(new Animal("Olifant", 5, false));
            animals.Add(new Animal("Giraffe", 5, false));
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
                    lbWagon.Items.Add(animal.Name);
                }
                Aantal++;
                lbWagon.Items.Add("");
            }

        }
    }
}
