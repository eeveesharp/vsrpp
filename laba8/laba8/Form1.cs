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

            Desktop desktop = new Desktop();

            if (radioButtonNotebook.Checked == true)
            {
                NotebookForm notebookForm = new NotebookForm(notebook);               

                notebookForm.Show();
                
                computers.Add(notebook);             
            }
            else if (radioButtonDesktop.Checked == true)
            {
                DesktopForm desktopForm = new DesktopForm(desktop);

                desktopForm.Show();

                computers.Add(desktop);                
            }          
        }

        private void buttonShortData_Click(object sender, EventArgs e)
        {
            listBoxComputer.Items.Clear();

            for (int i = 0; i < computers.Count; i++)
            {
                listBoxComputer.Items.Add(computers[i]);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBoxComputer.SelectedItem;

            if (selectedComputer is null)
            {
                MessageBox.Show("Выберите объект");
            }
            else
            {
                MessageBox.Show(selectedComputer.Show());
            }

            ComputerCollection strings = new ComputerCollection(computers);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in strings)
            {
                stringBuilder.Append(item);
                stringBuilder.Append(" ");
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void buttonChangeYear_Click(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBoxComputer.SelectedItem;

            ChangeYear changeYear = new ChangeYear(selectedComputer);

            changeYear.Show();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBoxComputer.SelectedItem;

            var comp = new Desktop((Desktop)selectedComputer);

            computers.Add(comp);
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBoxComputer.SelectedItem;

            computers.Remove(selectedComputer);

            MessageBox.Show(selectedComputer.Sell());
        }
    }
}
