using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        private string _font = "Microsoft Sans Serif";

        private int _fontSize = 8;

        private FontStyle _fontStyle = FontStyle.Regular;

        ToolStripLabel dateLabel;

        ToolStripLabel timeLabel;

        ToolStripLabel infoLabel;

        Timer timer;

        public Form1()
        {
            InitializeComponent();

            toolStripMenuRegister.DropDown.AutoClose = false;

            SetFont();

            SetFontSize();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip.Items.Add(infoLabel);
            statusStrip.Items.Add(dateLabel);
            statusStrip.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void SetFont()
        {
            toolStripComboBoxFontName.Items.Add("Magneto");
            toolStripComboBoxFontName.Items.Add("Lucida Handwriting");
            toolStripComboBoxFontName.Items.Add("Adobe Pi Std");
            toolStripComboBoxFontName.Items.Add("Mistral");
            toolStripComboBoxFontName.Items.Add("MV Boli");
        }

        private void SetFontSize()
        {
            for (int i = 0; i < 15; i++)
            {
                toolStripComboBoxFontSize.Items.Add($"{i + 1}");
            }
        }

        private void ReplaceMainTextRegister()
        {
            textBoxMainText.Font = new Font(_font, _fontSize, _fontStyle);
        }

        private void toolStripComboBoxFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _font = toolStripComboBoxFontName.Text;

            toolStripStatusLabelFontName.Text = $"Текущий шрифт: {_font}";

            ReplaceMainTextRegister();
        }

        private void toolStripComboBoxFontSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _fontSize = int.Parse(toolStripComboBoxFontSize.Text);

            ReplaceMainTextRegister();
        }

        private StringBuilder ReplaceTextAsInTheSentence(string[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        array[i] = array[i].Substring(0, 1).ToUpper() + array[i].Substring(1, array[i].Length - 1);
                    }

                    if (array[i] == "."
                        || array[i] == "!"
                        || array[i] == "?")
                    {
                        stringBuilder.Append(array[i]);

                        array[i + 1] = array[i + 1].Substring(0, 1).ToUpper() + array[i + 1].Substring(1, array[i + 1].Length - 1).ToLower();
                    }
                    else
                    {
                        stringBuilder.Append(array[i]);
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            return stringBuilder;
        }

        private void buttonForFind_Click(object sender, EventArgs e)
        {
            if (radioButtonWithoutRegister.Checked == true)
            {
                FindSentenceWithoutRegisterWord();
            }
            else if (radioButtonWithRegistre.Checked == true)
            {
                FindSentenceWithRegisterWord();
            }
            else
            {
                MessageBox.Show("Выберите нужный пункт");
            }
        }

        private void FindSentenceWithRegisterWord()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string pattern = @"([.!?])";

            string[] arrayText = Regex.Split(textBoxMainText.Text, pattern);

            for (int i = 0; i < arrayText.Length; i++)
            {
                if (arrayText[i].Contains(textBoxForFindPage.Text))
                {
                    stringBuilder.Append(arrayText[i]);

                    if (arrayText[i + 1] == "."
                        || arrayText[i + 1] == "!"
                        || arrayText[i + 1] == "?")
                    {
                        stringBuilder.Append(arrayText[i + 1]);
                    }
                }
            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void FindSentenceWithoutRegisterWord()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string pattern = @"([.!?])";

            string[] arrayText = Regex.Split(textBoxMainText.Text, pattern);

            for (int i = 0; i < arrayText.Length; i++)
            {
                if (arrayText[i].ToUpper().Contains(textBoxForFindPage.Text.ToUpper()))
                {
                    stringBuilder.Append(arrayText[i]);

                    if (arrayText[i + 1] == "."
                        || arrayText[i + 1] == "!"
                        || arrayText[i + 1] == "?")
                    {
                        stringBuilder.Append(arrayText[i + 1]);
                    }
                }
            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void buttonForReplace_Click(object sender, EventArgs e)
        {
            if (radioButtonForReplaceWithRegister.Checked == true)
            {
                textBoxMainText.Text = textBoxMainText.Text.Replace(textBoxForReplaceFirstWord.Text, textBoxForReplaceSecondWord.Text);

                textBoxForReplaceFirstWord.Clear();

                textBoxForReplaceSecondWord.Clear();
            }
            else if (radioButtonForReplaceWithoutRegister.Checked == true)
            {
                textBoxMainText.Text = Regex.Replace(textBoxMainText.Text, textBoxForReplaceFirstWord.Text, textBoxForReplaceSecondWord.Text, RegexOptions.IgnoreCase);

                textBoxForReplaceFirstWord.Clear();

                textBoxForReplaceSecondWord.Clear();
            }
            else
            {
                MessageBox.Show("Выберите нужный пункт");
            }
        }

        private void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            if (radioButtonForDeleteWithRegister.Checked == true)
            {
                textBoxMainText.Text = textBoxMainText.Text.Replace(textBoxForDelete.Text, string.Empty);
            }
            else if (radioButtonForDeleteWithoutRegister.Checked == true)
            {
                string text = textBoxMainText.Text;

                textBoxMainText.Text = Regex.Replace(textBoxMainText.Text, textBoxForDelete.Text, string.Empty, RegexOptions.IgnoreCase);
            }
            else
            {
                MessageBox.Show("Выберите нужный пункт");
            }
        }

        private void ToolStripMenuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Шрифт:{_font}\n" +
                $"Кол-во символов:{GetQuantitySymbol()}\n" +
                $"Текущая дата:{DateTime.Now}");
        }

        private string GetQuantitySymbol()
        {
            char[] array = textBoxMainText.Text.ToCharArray();

            return array.Length.ToString();
        }

        private void toolStripMenuAllToLowe_Click(object sender, EventArgs e)
        {
            toolStripMenuAllToUpper.Checked = false;

            toolStripMenuAsSentences.Checked = false;
        }

        private void toolStripMenuAllToUpper_Click(object sender, EventArgs e)
        {
            toolStripMenuAllToLowe.Checked = false;

            toolStripMenuAsSentences.Checked = false;
        }

        private void toolStripMenuAsSentences_Click(object sender, EventArgs e)
        {
            toolStripMenuAllToLowe.Checked = false;

            toolStripMenuAllToUpper.Checked = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            toolStripMenuRegister.DropDown.Close();

            toolStripMenuFont.DropDown.Close();
        }

        private void textBoxMainText_TextChanged(object sender, EventArgs e)
        {
            int oldIndex = textBoxMainText.SelectionStart;

            toolStripStatusLabelQuantitySymbol.Text = $"Кол-во символов: {GetQuantitySymbol()}";          

            if (toolStripMenuAllToLowe.Checked == true)
            {
                string text = textBoxMainText.Text.ToLower(new System.Globalization.CultureInfo("eu-En", false));

                textBoxMainText.Text = text;

                textBoxMainText.SelectionStart = oldIndex;
            }
            else if (toolStripMenuAllToUpper.Checked == true)
            {
                string text = textBoxMainText.Text.ToUpper(new System.Globalization.CultureInfo("eu-En", false));

                textBoxMainText.Text = text;

                textBoxMainText.SelectionStart = oldIndex;
            }
            else if (toolStripMenuAsSentences.Checked == true)
            {
                string pattern = @"([.!?])";

                string[] arrayText = Regex.Split(textBoxMainText.Text, pattern);

                textBoxMainText.Text = ReplaceTextAsInTheSentence(arrayText).ToString();

                textBoxMainText.SelectionStart = oldIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetLiteral().ToString());
        }

        private StringBuilder GetLiteral()
        {
            string pattern = @"([.!?])";

            string[] arrayText = textBoxMainText.Text.Split('.', '!', '?');

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < arrayText.Length; i++)
            {              
                string[] array = arrayText[i].Split(' ',' ',',');

                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                        stringBuilder.Append("< ");
                    }

                    int temp = 0;

                    char[] arrayChar = array[j].ToCharArray();

                    for (int m = 0; m < arrayChar.Length; m++)
                    {
                        if (arrayChar[m].ToString() == textBoxforLiteral.Text)
                        {
                            temp++;
                        }
                    }

                    stringBuilder.Append(temp + " ");

                    if (j == array.Length - 1)
                    {
                        stringBuilder.Append(">");
                    }
                }                
            }

            return stringBuilder;
        }
    }
}
