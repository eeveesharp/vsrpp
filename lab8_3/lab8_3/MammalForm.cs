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
    public partial class MammalForm : Form
    {
        private Mammal Mammal;

        public MammalForm(Mammal mammal)
        {
            InitializeComponent();

            Mammal = mammal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsCorrectData())
            {
                Mammal.Name = textBoxName.Text;
                Mammal.Weight = int.Parse(textBoxWeight.Text);
                Mammal.Age = int.Parse(textBoxAge.Text);
                Mammal.EarLength = int.Parse(textBoxEarLength.Text);
                Mammal.NumberOfTeeth = int.Parse(textBoxNumberOfTeeth.Text);

                Close();
            }
        }

        private bool IsCorrectData()
        {
            labelErrorName.Visible = false;
            labelErrorAge.Visible = false;
            labelErrorEarLength.Visible = false;
            labelErrorNumberOfTeeth.Visible = false;
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

            if ((!int.TryParse(textBoxEarLength.Text, out int earLength)) || (earLength > 100 || earLength < 1) || string.IsNullOrEmpty(textBoxEarLength.Text))
            {
                labelErrorEarLength.Visible = true;
                temp++;
            }

            if ((!int.TryParse(textBoxNumberOfTeeth.Text, out int numberOfTeeth)) || (numberOfTeeth > 50 || numberOfTeeth < 1) || string.IsNullOrEmpty(textBoxNumberOfTeeth.Text))
            {
                labelErrorNumberOfTeeth.Visible = true;
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
