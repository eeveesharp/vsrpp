using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class ChangeYear : Form
    {
        Computer computer;

        public ChangeYear(Computer computer)
        {
            InitializeComponent();

            this.computer = computer;

            labelDay.Text = computer.GetDate.Day.ToString();

            labelMonth.Text = computer.GetDate.Month.ToString();

            textBoxChangeYear.Text = computer.GetDate.Year.ToString();
        }

        private void buttonChangeYear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxChangeYear.Text, out int year))
            {
                computer.Year = year;

                Close();
            }
            else
            {
                MessageBox.Show("Введите корректный год");
            }
        }
    }
}
