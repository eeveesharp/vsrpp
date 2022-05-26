namespace lab7_7
{
    partial class SetData
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.labelErrorFirstName = new System.Windows.Forms.Label();
            this.labelErrorSecondName = new System.Windows.Forms.Label();
            this.labelErrorThirdName = new System.Windows.Forms.Label();
            this.labelErrorAge = new System.Windows.Forms.Label();
            this.labelErrorGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(169, 31);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(141, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(169, 76);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(141, 20);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(169, 122);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(141, 20);
            this.textBoxThirdName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(169, 169);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(141, 20);
            this.textBoxAge.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.comboBoxGender.Location = new System.Drawing.Point(169, 218);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(141, 21);
            this.comboBoxGender.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(121, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(94, 79);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 6;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Location = new System.Drawing.Point(96, 125);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(54, 13);
            this.labelThirdName.TabIndex = 7;
            this.labelThirdName.Text = "Отчество";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(95, 169);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(55, 13);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "Возвраст";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(123, 221);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Пол";
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(169, 266);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(141, 23);
            this.buttonEnterData.TabIndex = 10;
            this.buttonEnterData.Text = "Ввод";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // labelErrorFirstName
            // 
            this.labelErrorFirstName.AutoSize = true;
            this.labelErrorFirstName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFirstName.Location = new System.Drawing.Point(317, 37);
            this.labelErrorFirstName.Name = "labelErrorFirstName";
            this.labelErrorFirstName.Size = new System.Drawing.Size(128, 13);
            this.labelErrorFirstName.TabIndex = 11;
            this.labelErrorFirstName.Text = "Введите корректно имя";
            this.labelErrorFirstName.Visible = false;
            // 
            // labelErrorSecondName
            // 
            this.labelErrorSecondName.AutoSize = true;
            this.labelErrorSecondName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSecondName.Location = new System.Drawing.Point(317, 79);
            this.labelErrorSecondName.Name = "labelErrorSecondName";
            this.labelErrorSecondName.Size = new System.Drawing.Size(156, 13);
            this.labelErrorSecondName.TabIndex = 12;
            this.labelErrorSecondName.Text = "Введите корректно фамилию";
            this.labelErrorSecondName.Visible = false;
            // 
            // labelErrorThirdName
            // 
            this.labelErrorThirdName.AutoSize = true;
            this.labelErrorThirdName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorThirdName.Location = new System.Drawing.Point(317, 125);
            this.labelErrorThirdName.Name = "labelErrorThirdName";
            this.labelErrorThirdName.Size = new System.Drawing.Size(153, 13);
            this.labelErrorThirdName.TabIndex = 13;
            this.labelErrorThirdName.Text = "Введите корректно отчество";
            this.labelErrorThirdName.Visible = false;
            // 
            // labelErrorAge
            // 
            this.labelErrorAge.AutoSize = true;
            this.labelErrorAge.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAge.Location = new System.Drawing.Point(317, 172);
            this.labelErrorAge.Name = "labelErrorAge";
            this.labelErrorAge.Size = new System.Drawing.Size(155, 13);
            this.labelErrorAge.TabIndex = 14;
            this.labelErrorAge.Text = "Введите корректно возвраст";
            this.labelErrorAge.Visible = false;
            // 
            // labelErrorGender
            // 
            this.labelErrorGender.AutoSize = true;
            this.labelErrorGender.ForeColor = System.Drawing.Color.Red;
            this.labelErrorGender.Location = new System.Drawing.Point(317, 221);
            this.labelErrorGender.Name = "labelErrorGender";
            this.labelErrorGender.Size = new System.Drawing.Size(57, 13);
            this.labelErrorGender.TabIndex = 15;
            this.labelErrorGender.Text = "Выберите";
            this.labelErrorGender.Visible = false;
            // 
            // SetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.labelErrorGender);
            this.Controls.Add(this.labelErrorAge);
            this.Controls.Add(this.labelErrorThirdName);
            this.Controls.Add(this.labelErrorSecondName);
            this.Controls.Add(this.labelErrorFirstName);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "SetData";
            this.Text = "SetData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Label labelErrorFirstName;
        private System.Windows.Forms.Label labelErrorSecondName;
        private System.Windows.Forms.Label labelErrorThirdName;
        private System.Windows.Forms.Label labelErrorAge;
        private System.Windows.Forms.Label labelErrorGender;
    }
}