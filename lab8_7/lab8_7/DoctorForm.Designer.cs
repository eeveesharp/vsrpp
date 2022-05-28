namespace lab8_7
{
    partial class DoctorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxSpetialization = new System.Windows.Forms.TextBox();
            this.textBoxWages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.labelSpetialization = new System.Windows.Forms.Label();
            this.labelWages = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(167, 34);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(146, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(167, 93);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(146, 20);
            this.textBoxSecondName.TabIndex = 2;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(167, 147);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(146, 20);
            this.textBoxThirdName.TabIndex = 3;
            // 
            // textBoxSpetialization
            // 
            this.textBoxSpetialization.Location = new System.Drawing.Point(167, 252);
            this.textBoxSpetialization.Name = "textBoxSpetialization";
            this.textBoxSpetialization.Size = new System.Drawing.Size(146, 20);
            this.textBoxSpetialization.TabIndex = 4;
            // 
            // textBoxWages
            // 
            this.textBoxWages.Location = new System.Drawing.Point(167, 314);
            this.textBoxWages.Name = "textBoxWages";
            this.textBoxWages.Size = new System.Drawing.Size(146, 20);
            this.textBoxWages.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Location = new System.Drawing.Point(212, 131);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(54, 13);
            this.labelThirdName.TabIndex = 7;
            this.labelThirdName.Text = "Отчество";
            // 
            // labelSpetialization
            // 
            this.labelSpetialization.AutoSize = true;
            this.labelSpetialization.Location = new System.Drawing.Point(202, 236);
            this.labelSpetialization.Name = "labelSpetialization";
            this.labelSpetialization.Size = new System.Drawing.Size(86, 13);
            this.labelSpetialization.TabIndex = 8;
            this.labelSpetialization.Text = "Специализация";
            // 
            // labelWages
            // 
            this.labelWages.AutoSize = true;
            this.labelWages.Location = new System.Drawing.Point(212, 298);
            this.labelWages.Name = "labelWages";
            this.labelWages.Size = new System.Drawing.Size(55, 13);
            this.labelWages.TabIndex = 9;
            this.labelWages.Text = "Зарплата";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(205, 353);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(168, 200);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(145, 20);
            this.textBoxAge.TabIndex = 12;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 415);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelWages);
            this.Controls.Add(this.labelSpetialization);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWages);
            this.Controls.Add(this.textBoxSpetialization);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxSpetialization;
        private System.Windows.Forms.TextBox textBoxWages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label labelSpetialization;
        private System.Windows.Forms.Label labelWages;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}