using laba8.Models;
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
    public partial class DesktopFormChange : Form
    {
        private readonly Administrator _administrator;

        private readonly Desktop _desktop;

        public DesktopFormChange(Administrator administrator, Desktop desktop)
        {
            InitializeComponent();

            _administrator = administrator;

            _desktop = desktop;

            SetInfo();
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxNumberOfCores.Text, out int numberOfCores))
                && ((int.TryParse(textBoxQuantityRAM.Text, out int numberOfRam) && numberOfCores > 0 && numberOfCores < 64))
                && (int.TryParse(textBoxBP.Text, out int numberBP) && numberBP > 0 && numberBP < 2000))
            {
                _desktop.GPU = comboBoxGPU.Text;

                _desktop.CPU = comboBoxCPU.Text;

                _desktop.NumberOfCore = numberOfCores;

                _desktop.NumberOfRAM = numberOfRam;

                _desktop.PowerBlock = numberBP;

                _desktop.TypeBody = comboBoxTypeBody.Text;

                _desktop.SetDate = DateTime.Parse(datePickerForDesk.Text);

                _desktop.PriceWithoutNds = int.Parse(textBoxPrice.Text);
            }
            else
            {
                MessageBox.Show("Введите корректные значения");

                return;
            }

            Close();
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

            comboBoxTypeBody.Enabled = true;

            datePickerForDesk.Enabled = true;

            textBoxBP.ReadOnly = false;

            textBoxQuantityRAM.ReadOnly = false;

            textBoxPrice.ReadOnly = false;
        }

        private void SetInfo()
        {
            comboBoxCPU.Text = _desktop.CPU;

            comboBoxNumberOfCores.Text = _desktop.NumberOfCore.ToString();

            comboBoxGPU.Text = _desktop.GPU;

            comboBoxTypeBody.Text = _desktop.TypeBody;

            textBoxBP.Text = _desktop.PowerBlock.ToString();

            textBoxQuantityRAM.Text = _desktop.NumberOfRAM.ToString();

            textBoxPrice.Text = _desktop.PriceWithoutNds.ToString();

            datePickerForDesk.Text = _desktop.GetDate.ToShortDateString();
        }
    }
}
