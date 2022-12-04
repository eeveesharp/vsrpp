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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

            foreach (var item in AdministratorStorage.AdministratorsList)
            {
                comboBoxSecondNameForAuth.Items.Add(item.SecondName);
            }

            comboBoxSecondNameForAuth.Visible = true;
            textBoxPasswordForAuth.Visible = true;
        }

        private void radioButtonAdministratorForAuth_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSecondNameForAuth.Visible = true;
            textBoxPasswordForAuth.Visible = true;
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            Administrator admin = null;

            if (radioButtonAdministratorForAuth.Checked == true)
            {
                bool isValidData = IsValidAdministrator(comboBoxSecondNameForAuth.Text, textBoxPasswordForAuth.Text);

                if (isValidData)
                {
                    admin = GetAdmin(comboBoxSecondNameForAuth.Text, textBoxPasswordForAuth.Text);

                    ChoiceForm choiceForm = new ChoiceForm(this, admin);

                    choiceForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Введите корректные данные");
                }
            }
            else
            {
                ChoiceForm choiceForm = new ChoiceForm(this);

                choiceForm.ShowDialog();
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

        private Administrator GetAdmin(string secondName, string password)
        {
            foreach (var item in AdministratorStorage.AdministratorsList)
            {
                if (item.SecondName == secondName && item.Password == password)
                {
                    return item;
                }
            }

            return null;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                File<string>.WriteFile(HistoryStorage.History, "History");

                Application.Exit();
            }
        }
    }
}
