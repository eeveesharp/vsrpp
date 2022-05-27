using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_3
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Bird bird = new Bird();

            Mammal mammal = new Mammal();

            if (radioButtonBird.Checked == true)
            {
                BirdForm birdForm = new BirdForm(bird);

                birdForm.Show();

                animals.Add(bird);
            }
            else if (radioButtonMammal.Checked == true)
            {
                MammalForm mammalForm = new MammalForm(mammal);

                mammalForm.Show();

                animals.Add(mammal);
            }
        }

        private void buttonWriteData_Click(object sender, EventArgs e)
        {
            listBoxAnimal.Items.Clear();

            for (int i = 0; i < animals.Count; i++)
            {
                listBoxAnimal.Items.Add(animals[i]);
            }
        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal selectedAnimal = (Animal)listBoxAnimal.SelectedItem;

            MessageBox.Show(selectedAnimal.Information());
        }
    }
}
