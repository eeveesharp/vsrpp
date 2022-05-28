using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_7
{
    public partial class PatientForm : Form
    {
        private Patient Patient;

        public PatientForm(Patient patient)
        {
            InitializeComponent();

            this.Patient = patient;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (IsEmptyStr())
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (!int.TryParse(textBoxAge.Text,out int age) || age > 100 || age < 1)
                {
                    MessageBox.Show("Введите корректный возраст");
                }
                else
                {
                    Patient.FirstName = textBoxFirstName.Text;

                    Patient.SecondName = textBoxSecondName.Text;

                    Patient.ThirdName = textBoxThirdName.Text;

                    Patient.Age = age;

                    Patient.Diagnosis = textBoxDiagnosis.Text;

                    Patient.Recommendations = textBoxRecomendations.Text;

                    Close();
                }               
            }
        }

        private bool IsEmptyStr()
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text)
                || string.IsNullOrEmpty(textBoxSecondName.Text)
                || string.IsNullOrEmpty(textBoxThirdName.Text)
                || string.IsNullOrEmpty(textBoxRecomendations.Text)
                || string.IsNullOrEmpty(textBoxDiagnosis.Text)
                || string.IsNullOrEmpty(textBoxAge.Text))
            {
                return true;
            }

            return false;
        }
    }
}
