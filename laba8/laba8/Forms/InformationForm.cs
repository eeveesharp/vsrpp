using laba8.Enums;
using laba8.Models;
using laba8.Services;
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
    public partial class InformationForm : Form
    {
        private Administrator _administrator;

        public InformationForm(Administrator administrator)
        {
            InitializeComponent();

            _administrator = administrator;

            InitData();

            textBoxAgeInfo.ReadOnly = true;
            textBoxPasswordInfo.ReadOnly = true;
            textBoxSecondNameInfo.ReadOnly = true;
            comboBoxRoleInfo.Enabled = false;
        }

        private void buttonChangeAdminInfo_Click(object sender, EventArgs e)
        {
            textBoxAgeInfo.ReadOnly = false;
            textBoxPasswordInfo.ReadOnly = false;
            textBoxSecondNameInfo.ReadOnly = false;
            comboBoxRoleInfo.Enabled = true;
        }

        private void InitData()
        {
            textBoxAgeInfo.Text = _administrator.Age.ToString();
            textBoxPasswordInfo.Text = _administrator.Password.ToString();
            textBoxSecondNameInfo.Text = _administrator.SecondName.ToString();
            comboBoxRoleInfo.Text = _administrator.Role.ToString();
        }

        private void buttonOkInformation_Click(object sender, EventArgs e)
        {
            _administrator.Age = int.Parse(textBoxAgeInfo.Text);
            _administrator.Password = textBoxPasswordInfo.Text;
            _administrator.SecondName = textBoxSecondNameInfo.Text;
           // _administrator.Role = comboBoxRoleInfo.Text;

            File<Administrator>.WriteFile(AdministratorStorage.AdministratorsList, "administrators");           

            Close();
        }
    }
}
