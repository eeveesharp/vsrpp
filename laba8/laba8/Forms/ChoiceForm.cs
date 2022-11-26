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
    public partial class ChoiceForm : Form
    {
        private Administrator _administrator;

        private AuthForm _authForm;

        public ChoiceForm(AuthForm authForm, Administrator administrator)
        {
            InitializeComponent();

            _administrator = administrator;

            _authForm = authForm;
        }

        public ChoiceForm(AuthForm authForm)
        {
            InitializeComponent();

            _authForm = authForm;

            if (_administrator is null)
            {
                buttonAdminInformation.Visible = false;
                button3.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.ShowDialog();
        }

        private void buttonAdminInformation_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm(_administrator);

            informationForm.ShowDialog();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();

            productsForm.ShowDialog();
        }

        private void buttonSingOut_Click(object sender, EventArgs e)
        {
            _authForm.Close();
        }
    }
}
