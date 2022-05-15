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
    public partial class MainForm : Form
    {
        private Computer Computer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Computer = new Computer();

            DataForm dataForm = new DataForm(Computer);

            dataForm.Show();
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {

        }
    }
}
