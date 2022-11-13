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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

            foreach (var item in AdministratorStorage.AdministratorsList)
            {
                comboBoxSecondNameForAuth.Items.Add(item.SecondName);
            }           
        }

        private void radioButtonAdministratorForAuth_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSecondNameForAuth.Visible = true;
            textBoxPasswordForAuth.Visible = true;
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            if (radioButtonAdministratorForAuth.Checked == true)
            {
                bool isValidData = IsValidAdministrator(comboBoxSecondNameForAuth.Text, textBoxPasswordForAuth.Text);

                if (isValidData)
                {
                    MainForm mainForm = new MainForm();

                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                MainForm mainForm = new MainForm();

                mainForm.Show();
            }          
        }

        private void radioButtonUserForAuth_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSecondNameForAuth.Visible = false;
            textBoxPasswordForAuth.Visible = false;
        }

        private bool IsValidAdministrator(string secondName, string password)
        {
            foreach (var item in AdministratorStorage.AdministratorsList)
            {
                if (item.SecondName == secondName && item.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
