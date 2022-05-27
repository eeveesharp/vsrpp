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
    public partial class BirdForm : Form
    {
        private Bird Bird;

        public BirdForm(Bird bird)
        {
            InitializeComponent();

            Bird = bird;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsCorrectData())
            {
                Bird.Name = textBoxName.Text;
                Bird.Weight = int.Parse(textBoxWeight.Text);
                Bird.Age = int.Parse(textBoxAge.Text);
                Bird.WingLength = int.Parse(textBoxWingLength.Text);
                Bird.BeakColor = comboBoxBeakColor.Text;

                Close();
            }
        }

        private bool IsCorrectData()
        {
            labelErrorName.Visible = false;
            labelErrorAge.Visible = false;
            labelErrorColorBeak.Visible = false;
            labelErrorWingLength.Visible = false;
            labelErrorWeight.Visible = false;

            int temp = 0;

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                labelErrorName.Visible = true;
                temp++;
            }

            if ((!int.TryParse(textBoxAge.Text, out int age)) || (age > 50 || age < 1) || string.IsNullOrEmpty(textBoxAge.Text))
            {
                labelErrorAge.Visible = true;
                temp++;
            }

            if (string.IsNullOrEmpty(comboBoxBeakColor.Text))
            {
                labelErrorColorBeak.Visible = true;
                temp++;
            }

            if ((!int.TryParse(textBoxWingLength.Text, out int wingLength)) || (wingLength > 50 || wingLength < 1) || string.IsNullOrEmpty(textBoxWingLength.Text))
            {
                labelErrorWingLength.Visible = true;
                temp++;
            }

            if ((!int.TryParse(textBoxWeight.Text, out int weight)) || (weight > 150 || weight < 1) || string.IsNullOrEmpty(textBoxWeight.Text))
            {
                labelErrorWeight.Visible = true;
                temp++;
            }

            if (temp > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
