using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_7
{
    public partial class SetData : Form
    {
        private Human _human;

        public SetData(Human human):this()
        {
            this._human = human;
        }

        public SetData()
        {
            InitializeComponent();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            SetVisible();

            if (IsCorrectData(textBoxFirstName.Text))
            {
                labelErrorFirstName.Visible = true;
            }

            if (IsCorrectData(textBoxSecondName.Text))
            {
                labelErrorSecondName.Visible = true;
            }

            if (IsCorrectData(textBoxThirdName.Text))
            {
                labelErrorThirdName.Visible = true;
            }

            if (IsCorrectData(comboBoxGender.Text))
            {
                labelErrorGender.Visible = true;
            }

            if (IsCorrectAge(textBoxAge.Text))
            {
                labelErrorAge.Visible = true;
            }

            if (!IsCorrectData(textBoxFirstName.Text)
                && !IsCorrectData(textBoxSecondName.Text)
                && !IsCorrectData(textBoxThirdName.Text)
                && !IsCorrectAge(textBoxAge.Text)
                && !IsCorrectData(comboBoxGender.Text))
            {
                int age = int.Parse(textBoxAge.Text);

                _human.FirstName = textBoxFirstName.Text;

                _human.SecondName = textBoxSecondName.Text;

                _human.ThirdName = textBoxThirdName.Text;

                _human.Age = age;

                _human.Gender = comboBoxGender.Text;

                Close();
            }
        }

        private bool IsCorrectData(string info)
        {
            bool isCorrect = false;

            if (string.IsNullOrEmpty(info))
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        private bool IsCorrectAge(string age)
        {
            bool isCorrect = false;

            if ((!int.TryParse(age, out int number) || (number < 1 || number > 100)) || string.IsNullOrEmpty(age))
            {
                isCorrect = true;
            }

            return isCorrect;
        }

        private void SetVisible()
        {
            labelErrorSecondName.Visible = false;
            labelErrorThirdName.Visible = false;
            labelErrorFirstName.Visible = false;
            labelErrorAge.Visible = false;
            labelErrorGender.Visible = false;
        }    
    }
}
