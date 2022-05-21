using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class DataForm : Form
    {
        Computer Computer;

        public DataForm(Computer computer):this()
        {
            this.Computer = computer;
        }

        public DataForm()
        {            
            InitializeComponent();

            comboBoxColor.Items.AddRange(new string[] { "Black", "Red", "Green", "White" });
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            bool isCorrect = isCorrectData();

            if (isCorrect)
            {
                labelError.Visible = true;
            }
            else
            {
                Computer.Color = comboBoxColor.Text;

                Computer.RAM = textBoxRam.Text;

                Computer.GPU = textBoxGpu.Text;

                Computer.CPU = textBoxCpu.Text;

                labelError.Visible = false;

                Close();
            }        
        }

        private bool isCorrectData()
        {
            bool isCorrect = false;

            Object selectedItem = comboBoxColor.SelectedItem;

            if (selectedItem is null
                || string.IsNullOrEmpty(textBoxCpu.Text)
                || string.IsNullOrEmpty(textBoxGpu.Text)
                || string.IsNullOrEmpty(textBoxRam.Text))
            {
                isCorrect = true;
            }

            return isCorrect;
        }
    }
}
