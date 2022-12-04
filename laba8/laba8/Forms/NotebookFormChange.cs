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
    public partial class NotebookFormChange : Form
    {
        private readonly Administrator _administrator;

        private readonly Notebook _notebook;

        public NotebookFormChange(Administrator administrator, Notebook notebook)
        {
            InitializeComponent();

            HistoryStorage.Journal.OnChange += Listener.Change;

            _administrator = administrator;

            _notebook = notebook;

            SetInfo();
        }

        private void buttonChangeData_Click(object sender, EventArgs e)
        {          
            if (_administrator != null && _administrator.Role == "Accountant")
            {
                SetSettingsForAcc();
            }
            else if (_administrator.Role == "Chief" || _administrator.Role == "SalesDepartment")
            {
                SetSettingsForChiefAndSalesDepartment();
            }
        }

        private void SetSettingsForAcc()
        {
            textBoxPrice.ReadOnly = false;
        }

        private void SetSettingsForChiefAndSalesDepartment()
        {
            comboBoxCPU.Enabled = true;

            comboBoxNumberOfCores.Enabled = true;

            comboBoxGPU.Enabled = true;

            comboBoxBattery.Enabled = true;

            dateTimePicker1.Enabled = true;

            textBoxQuantityRAM.ReadOnly = false;

            textBoxPrice.ReadOnly = false;

            textBoxWorkHours.ReadOnly = true;
        }

        private void SetInfo()
        {
            comboBoxCPU.Text = _notebook.CPU;

            comboBoxNumberOfCores.Text = _notebook.NumberOfCore.ToString();

            comboBoxGPU.Text = _notebook.GPU;

            comboBoxBattery.Text = _notebook.TypeBattery;

            textBoxQuantityRAM.Text = _notebook.NumberOfRAM.ToString();

            textBoxPrice.Text = _notebook.PriceWithoutNds.ToString();

            textBoxWorkHours.Text = _notebook.WorkHours.ToString();

            dateTimePicker1.Text = _notebook.GetDate.ToShortDateString();
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfCores))
               && ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfRam) && numberOfCores > 0 && numberOfCores < 64))
               && (int.TryParse(textBoxWorkHours.Text, out int numberWorkHours) && numberWorkHours > 0 && numberWorkHours < 15))
            {
                _notebook.GPU = comboBoxGPU.Text;

                _notebook.CPU = comboBoxCPU.Text;

                _notebook.NumberOfCore = numberOfCores;

                _notebook.NumberOfRAM = numberOfRam;

                _notebook.WorkHours = numberWorkHours;

                _notebook.TypeBattery = comboBoxBattery.Text;

                _notebook.SetDate = DateTime.Parse(dateTimePicker1.Text);

                _notebook.PriceWithoutNds = int.Parse(textBoxPrice.Text);
            }

            HistoryStorage.Journal.Change(_notebook);

            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HistoryStorage.Journal.Remove(_notebook);

            Close();
        }
    }
}
