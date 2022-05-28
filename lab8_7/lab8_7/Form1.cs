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
    public partial class Form1 : Form
    {
        private List<Human> humans;

        public Form1()
        {
            InitializeComponent();

            humans = new List<Human>();
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            if (radioButtonDoctor.Checked is true)
            {
                Doctor doctor = new Doctor();

                DoctorForm doctorForm = new DoctorForm(doctor);

                doctorForm.Show();

                humans.Add(doctor);
            }
            else if (radioButtonPatient.Checked is true)
            {
                Patient patient = new Patient();

                PatientForm doctorForm = new PatientForm(patient);

                doctorForm.Show();

                humans.Add(patient);
            }
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < humans.Count; i++)
            {
                listBox1.Items.Add(humans[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Human selectedComputer = (Human)listBox1.SelectedItem;

            MessageBox.Show(selectedComputer.GetInfo());
        }
    }
}
