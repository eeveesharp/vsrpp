namespace lab8_3
{
    partial class BirdForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxWingLength = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelWingLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBeakColor = new System.Windows.Forms.ComboBox();
            this.labelBeakColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelErrorWeight = new System.Windows.Forms.Label();
            this.labelErrorWingLength = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelErrorAge = new System.Windows.Forms.Label();
            this.labelErrorColorBeak = new System.Windows.Forms.Label();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(188, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(188, 69);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(188, 117);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 2;
            // 
            // textBoxWingLength
            // 
            this.textBoxWingLength.Location = new System.Drawing.Point(188, 160);
            this.textBoxWingLength.Name = "textBoxWingLength";
            this.textBoxWingLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxWingLength.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(91, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Название птицы";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(127, 72);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 13);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Возраст";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(156, 120);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(26, 13);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Вес";
            // 
            // labelWingLength
            // 
            this.labelWingLength.AutoSize = true;
            this.labelWingLength.Location = new System.Drawing.Point(95, 163);
            this.labelWingLength.Name = "labelWingLength";
            this.labelWingLength.Size = new System.Drawing.Size(87, 13);
            this.labelWingLength.TabIndex = 7;
            this.labelWingLength.Text = "Длина крыльев";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "мм";
            // 
            // comboBoxBeakColor
            // 
            this.comboBoxBeakColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeakColor.FormattingEnabled = true;
            this.comboBoxBeakColor.Items.AddRange(new object[] {
            "Желтый",
            "Серый",
            "Коричневый",
            "Белый"});
            this.comboBoxBeakColor.Location = new System.Drawing.Point(188, 206);
            this.comboBoxBeakColor.Name = "comboBoxBeakColor";
            this.comboBoxBeakColor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBeakColor.TabIndex = 9;
            // 
            // labelBeakColor
            // 
            this.labelBeakColor.AutoSize = true;
            this.labelBeakColor.Location = new System.Drawing.Point(115, 209);
            this.labelBeakColor.Name = "labelBeakColor";
            this.labelBeakColor.Size = new System.Drawing.Size(67, 13);
            this.labelBeakColor.TabIndex = 10;
            this.labelBeakColor.Text = "Цвет клюва";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelErrorWeight
            // 
            this.labelErrorWeight.AutoSize = true;
            this.labelErrorWeight.ForeColor = System.Drawing.Color.Red;
            this.labelErrorWeight.Location = new System.Drawing.Point(323, 120);
            this.labelErrorWeight.Name = "labelErrorWeight";
            this.labelErrorWeight.Size = new System.Drawing.Size(161, 13);
            this.labelErrorWeight.TabIndex = 12;
            this.labelErrorWeight.Text = "Введите корректное значение";
            this.labelErrorWeight.Visible = false;
            // 
            // labelErrorWingLength
            // 
            this.labelErrorWingLength.AutoSize = true;
            this.labelErrorWingLength.ForeColor = System.Drawing.Color.Red;
            this.labelErrorWingLength.Location = new System.Drawing.Point(323, 163);
            this.labelErrorWingLength.Name = "labelErrorWingLength";
            this.labelErrorWingLength.Size = new System.Drawing.Size(161, 13);
            this.labelErrorWingLength.TabIndex = 13;
            this.labelErrorWingLength.Text = "Введите корректное значение";
            this.labelErrorWingLength.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "кг";
            // 
            // labelErrorAge
            // 
            this.labelErrorAge.AutoSize = true;
            this.labelErrorAge.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAge.Location = new System.Drawing.Point(323, 72);
            this.labelErrorAge.Name = "labelErrorAge";
            this.labelErrorAge.Size = new System.Drawing.Size(161, 13);
            this.labelErrorAge.TabIndex = 15;
            this.labelErrorAge.Text = "Введите корректное значение";
            this.labelErrorAge.Visible = false;
            // 
            // labelErrorColorBeak
            // 
            this.labelErrorColorBeak.AutoSize = true;
            this.labelErrorColorBeak.ForeColor = System.Drawing.Color.Red;
            this.labelErrorColorBeak.Location = new System.Drawing.Point(323, 209);
            this.labelErrorColorBeak.Name = "labelErrorColorBeak";
            this.labelErrorColorBeak.Size = new System.Drawing.Size(161, 13);
            this.labelErrorColorBeak.TabIndex = 16;
            this.labelErrorColorBeak.Text = "Введите корректное значение";
            this.labelErrorColorBeak.Visible = false;
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorName.Location = new System.Drawing.Point(323, 31);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(161, 13);
            this.labelErrorName.TabIndex = 17;
            this.labelErrorName.Text = "Введите корректное значение";
            this.labelErrorName.Visible = false;
            // 
            // BirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 278);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.labelErrorColorBeak);
            this.Controls.Add(this.labelErrorAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelErrorWingLength);
            this.Controls.Add(this.labelErrorWeight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBeakColor);
            this.Controls.Add(this.comboBoxBeakColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWingLength);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxWingLength);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Name = "BirdForm";
            this.Text = "BirdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxWingLength;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelWingLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBeakColor;
        private System.Windows.Forms.Label labelBeakColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelErrorWeight;
        private System.Windows.Forms.Label labelErrorWingLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelErrorAge;
        private System.Windows.Forms.Label labelErrorColorBeak;
        private System.Windows.Forms.Label labelErrorName;
    }
}