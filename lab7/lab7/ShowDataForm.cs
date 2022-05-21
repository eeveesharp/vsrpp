using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class ShowDataForm : Form
    {
        public ShowDataForm(Computer Computer)
        {
            InitializeComponent();

            labelColor.Text = $"Цвет:{Computer.Color}";

            labelCpu.Text = $"Процессор:{Computer.CPU}";

            labelGpu.Text = $"Видеокарта:{Computer.GPU}";

            labelRam.Text = $"Оперативная память:{Computer.RAM}";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
