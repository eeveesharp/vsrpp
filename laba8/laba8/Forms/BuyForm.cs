using laba8.Models;
using laba8.Storage;
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
        private readonly Computer _computer;

        private readonly Administrator _administator;

        public BuyForm(Computer computer)
        {
            InitializeComponent();

            _computer = computer;

            HistoryStorage.Journal.OnSell += Listener.Sell;

            labelInfo.Text = computer.Show();

            textBoxBuy.Visible = true;

            buttonBuy.Visible = true;
        }

        public BuyForm(Computer computer, Administrator administator)
        {
            InitializeComponent();

            labelInfo.Text = computer.Show();

            _computer = computer;

            _administator = administator;    

            if (_administator.Role == "SalesDepartment" || _administator.Role == "Chief")
            {
                buttonSell.Visible = true;
            }
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

        private void buttonSell_Click(object sender, EventArgs e)
        {
            _computer.Sell();

            HistoryStorage.Journal.Sell(_computer);

            Close();
        }
    }
}
