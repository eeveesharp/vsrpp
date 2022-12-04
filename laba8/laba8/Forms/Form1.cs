using laba8.Forms;
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

namespace laba8
{
    public partial class MainForm : Form
    {
        private readonly Administrator _administrator;

        private readonly Journal<Computer> _journal = new Journal<Computer>();

        public MainForm(Administrator administrator)
        {
            InitializeComponent();

            _administrator = administrator;

            listBoxComputer.Items.Clear();

            for (int i = 0; i < ComputerStorage.ComputersList.Count; i++)
            {
                listBoxComputer.Items.Add(ComputerStorage.ComputersList[i]);
            }

            //_journal.OnChange += new EventHandler(Listener.Change);
            _journal.OnAdd += Listener.Add;
            //_journal.OnSell += new EventHandler(Listener.Sell);
            //_journal.OnDelete += new EventHandler(Listener.Delete);
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();

            Desktop desktop = new Desktop();

            if (radioButtonNotebook.Checked == true)
            {
                NotebookForm notebookForm = new NotebookForm(notebook);               

                notebookForm.ShowDialog();
                
                ComputerStorage.ComputersList.Add(notebook);

                _journal.Create(notebook);
            }
            else if (radioButtonDesktop.Checked == true)
            {
                DesktopForm desktopForm = new DesktopForm(desktop);

                desktopForm.ShowDialog();

                ComputerStorage.ComputersList.Add(desktop);                                 
            }

            listBoxComputer.Items.Clear();

            for (int i = 0; i < ComputerStorage.ComputersList.Count; i++)
            {
                listBoxComputer.Items.Add(ComputerStorage.ComputersList[i]);
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

            ComputerStorage.ComputersList.Add(comp);
        }

        private void listBoxComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBoxComputer.SelectedItem;

            if (selectedComputer is Desktop)
            {
                DesktopFormChange desktopFormChange = new DesktopFormChange(_administrator, (Desktop)selectedComputer);

                desktopFormChange.ShowDialog();

                listBoxComputer.Items.Clear();

                for (int i = 0; i < ComputerStorage.ComputersList.Count; i++)
                {
                    listBoxComputer.Items.Add(ComputerStorage.ComputersList[i]);
                }
            }
            else if (selectedComputer is Notebook)
            {
                NotebookFormChange notebookFormChange = new NotebookFormChange(_administrator, (Notebook)selectedComputer);

                notebookFormChange.ShowDialog();

                listBoxComputer.Items.Clear();

                for (int i = 0; i < ComputerStorage.ComputersList.Count; i++)
                {
                    listBoxComputer.Items.Add(ComputerStorage.ComputersList[i]);
                }
            }
        }
    }
}
