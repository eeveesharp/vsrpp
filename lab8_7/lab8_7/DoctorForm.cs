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
    public partial class DoctorForm : Form
    {
        private Doctor Doctor;

        public DoctorForm(Doctor doctor)
        {
            InitializeComponent();

            this.Doctor = doctor;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (IsEmptyStr())
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (!int.TryParse(textBoxAge.Text, out int age) || age > 100 || age < 18)
                {
                    MessageBox.Show("Введите корректный возраст");
                }
                else if (!double.TryParse(textBoxWages.Text, out double wages) || wages > 3000 || wages < 1)
                {
                    MessageBox.Show("Введите корректную зарплату");
                }
                else
                {
                    Doctor.FirstName = textBoxFirstName.Text;

                    Doctor.SecondName = textBoxSecondName.Text;

                    Doctor.ThirdName = textBoxThirdName.Text;

                    Doctor.Age = age;

                    Doctor.Wages = wages;

                    Doctor.Specialization = textBoxSpetialization.Text;

                    Close();
                }
            }
        }

        private bool IsEmptyStr()
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text)
                || string.IsNullOrEmpty(textBoxSecondName.Text)
                || string.IsNullOrEmpty(textBoxThirdName.Text)
                || string.IsNullOrEmpty(textBoxWages.Text)
                || string.IsNullOrEmpty(textBoxSpetialization.Text)
                || string.IsNullOrEmpty(textBoxAge.Text))
            {
                return true;
            }

            return false;
        }
    }
}
