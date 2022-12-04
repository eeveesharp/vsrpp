using laba8.Enums;
using laba8.Models;
using laba8.Services;
using laba8.Storage;
using System;
using System.Collections;
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
    public partial class ProductsForm : Form
    {
        private readonly Administrator _administrator;

        public ProductsForm(Administrator administrator)
        {
            _administrator = administrator;

            InitializeComponent();

            foreach (var item in ComputerStorage.ComputersList)
            {
                listBox1.Items.Add(item);
            }

            if (_administrator != null && (_administrator.Role == "Accountant" || _administrator.Role == "Chief"))
            {
                checkBoxSelledProducts.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Computer selectedComputer = (Computer)listBox1.SelectedItem;

            if (selectedComputer is null)
            {
                MessageBox.Show("Выберите объект");
            }
            else
            {
                if (_administrator is null)
                {
                    BuyForm buyForm = new BuyForm(selectedComputer);

                    buyForm.ShowDialog();
                }
                else if (_administrator.Role == "Accountant")
                {
                    BuyForm buyForm = new BuyForm(selectedComputer, _administrator);

                    buyForm.ShowDialog();
                }
                else if (_administrator.Role == "SalesDepartment" || _administrator.Role == "Chief")
                {
                    BuyForm buyForm = new BuyForm(selectedComputer, _administrator);

                    buyForm.ShowDialog();
                }
            }
        }

        private void radioButtonAllDesktops_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSelledProducts.Checked = false;

            listBox1.Items.Clear();

            button1.Visible = true;

            button1.Text = "Сортировка по блоку питания";

            foreach (var item in GetListDesktop())
            {
                listBox1.Items.Add(item);
            }
        }

        private void radioButtonAllNotebooks_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSelledProducts.Checked = false;

            listBox1.Items.Clear();

            button1.Visible = true;

            button1.Text = "Сортировка по часам работы";

            foreach (var item in GetListNotebook())
            {
                listBox1.Items.Add(item);
            }
        }

        private void radioButtonAllProducts_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSelledProducts.Checked = false;

            listBox1.Items.Clear();

            button1.Visible = false;

            foreach (var item in ComputerStorage.ComputersList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void buttonSortByDate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ComputerCollection collection = new ComputerCollection(ComputerStorage.ComputersList);

            if (radioButtonAllDesktops.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortDesktopByDate(collection))
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortDesktopByDate(collection))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortNotebookByDate(collection))
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortDesktopByDate(collection))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortAllByDate(collection))
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortAllByDate(collection))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void buttonSortByPrice_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortDesktopByPrice())
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortDesktopByPrice())
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortNotebookByPrice())
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortDesktopByPrice())
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in SortServices.SortAllByPrice())
                    {
                        if (item.IsSell)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in SortServices.SortAllByPrice())
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                DesktopCollection collection = new DesktopCollection(GetListDesktop());

                foreach (var item in SortServices.SortDesktopByBlockPower(collection))
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                NotebookCollection collection = new NotebookCollection(GetListNotebook());

                foreach (var item in SortServices.SortNotebookByWorkHours(collection))
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
        }

        private List<Desktop> GetListDesktop()
        {
            var list = new List<Desktop>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Desktop)
                {
                    list.Add((Desktop)item);
                }
            }

            return list;
        }

        private List<Notebook> GetListNotebook()
        {
            var list = new List<Notebook>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Notebook)
                {
                    list.Add((Notebook)item);
                }
            }

            return list;
        }

        private void buttonFindByYear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                foreach (var item in GetListDesktop())
                {
                    if (item.Year == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                foreach (var item in GetListNotebook())
                {
                    if (item.Year == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in ComputerStorage.ComputersList)
                {
                    if (item.Year == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void buttonFindByPrice_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                foreach (var item in GetListDesktop())
                {
                    if (item.PriceWithoutNds == decimal.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                foreach (var item in GetListNotebook())
                {
                    if (item.PriceWithoutNds == decimal.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in ComputerStorage.ComputersList)
                {
                    if (item.PriceWithoutNds == decimal.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void buttonFindByCPU_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                foreach (var item in GetListDesktop())
                {
                    if (item.CPU == textBoxFind.Text)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                foreach (var item in GetListNotebook())
                {
                    if (item.CPU == textBoxFind.Text)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in ComputerStorage.ComputersList)
                {
                    if (item.CPU == textBoxFind.Text)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void buttonFindByRam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                foreach (var item in GetListDesktop())
                {
                    if (item.NumberOfRAM == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                foreach (var item in GetListNotebook())
                {
                    if (item.NumberOfRAM == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in ComputerStorage.ComputersList)
                {
                    if (item.NumberOfRAM == int.Parse(textBoxFind.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void checkBoxSelledProducts_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (radioButtonAllDesktops.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in GetListDesktop())
                    {
                        if (item.IsSell == true)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in GetListDesktop())
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if (radioButtonAllNotebooks.Checked == true)
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in GetListNotebook())
                    {
                        if (item.IsSell == true)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in GetListNotebook())
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                if (checkBoxSelledProducts.Checked == true)
                {
                    foreach (var item in ComputerStorage.ComputersList)
                    {
                        if (item.IsSell == true)
                        {
                            listBox1.Items.Add(item);
                        }
                    }
                }
                else
                {
                    foreach (var item in ComputerStorage.ComputersList)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }
    }
}
