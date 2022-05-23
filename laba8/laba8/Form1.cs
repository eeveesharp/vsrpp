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
    public partial class MainForm : Form
    {
        List<Computer> computers = new List<Computer>();      

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();

            if (radioButtonNotebook.Checked == true)
            {
                NotebookForm notebookForm = new NotebookForm(notebook);

                computers.Add(notebook);

                notebookForm.Show();
            }
        }
    }
}
