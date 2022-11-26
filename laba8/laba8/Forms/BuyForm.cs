using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8.Forms
{
    public partial class BuyForm : Form
    {
        Computer _computer;

        public BuyForm(Computer computer)
        {
            InitializeComponent();

            _computer = computer;

            labelInfo.Text = computer.Show();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxBuy.Text, out decimal number) && number > _computer.PriceWithNds)
            {
                _computer.Sell();

                Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
