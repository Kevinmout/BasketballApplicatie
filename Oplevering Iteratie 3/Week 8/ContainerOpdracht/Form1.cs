using ContainerOpdracht_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerOpdracht
{
    public partial class Form1 : Form
    {
        List<ContainerOpdracht_Logic.Container> containers = new List<ContainerOpdracht_Logic.Container>();
        Vrachtschip vrachtschip = new Vrachtschip(0,100000,0,0);
        public Form1()
        {
            InitializeComponent();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            containers.Add(new ContainerOpdracht_Logic.Container(8000,false,false));
        }
    }
}
