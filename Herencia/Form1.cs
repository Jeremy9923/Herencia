using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dog dog = new dog();


            dog.animalLegs = 4;
            dog.animalSpecies = "pitbull";
            dog.animalEat = false;

            MessageBox.Show(dog.getInfo());
            MessageBox.Show(dog.species());

            MessageBox.Show(dog.comer());
        }
    }
}
