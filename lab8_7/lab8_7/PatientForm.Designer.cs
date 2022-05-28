namespace lab8_7
{
    partial class PatientForm
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelWages = new System.Windows.Forms.Label();
            this.labelSpetialization = new System.Windows.Forms.Label();
            this.labelThirdName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRecomendations = new System.Windows.Forms.TextBox();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(206, 335);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 21;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelWages
            // 
            this.labelWages.AutoSize = true;
            this.labelWages.Location = new System.Drawing.Point(203, 284);
            this.labelWages.Name = "labelWages";
            this.labelWages.Size = new System.Drawing.Size(82, 13);
            this.labelWages.TabIndex = 20;
            this.labelWages.Text = "Рекомендации";
            // 
            // labelSpetialization
            // 
            this.labelSpetialization.AutoSize = true;
            this.labelSpetialization.Location = new System.Drawing.Point(216, 228);
            this.labelSpetialization.Name = "labelSpetialization";
            this.labelSpetialization.Size = new System.Drawing.Size(51, 13);
            this.labelSpetialization.TabIndex = 19;
            this.labelSpetialization.Text = "Диагноз";
            // 
            // labelThirdName
            // 
            this.labelThirdName.AutoSize = true;
            this.labelThirdName.Location = new System.Drawing.Point(211, 122);
            this.labelThirdName.Name = "labelThirdName";
            this.labelThirdName.Size = new System.Drawing.Size(54, 13);
            this.labelThirdName.TabIndex = 18;
            this.labelThirdName.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // textBoxRecomendations
            // 
            this.textBoxRecomendations.Location = new System.Drawing.Point(168, 300);
            this.textBoxRecomendations.Name = "textBoxRecomendations";
            this.textBoxRecomendations.Size = new System.Drawing.Size(146, 20);
            this.textBoxRecomendations.TabIndex = 16;
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(168, 244);
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(146, 20);
            this.textBoxDiagnosis.TabIndex = 15;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(168, 138);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(146, 20);
            this.textBoxThirdName.TabIndex = 14;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(168, 86);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(146, 20);
            this.textBoxSecondName.TabIndex = 13;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(168, 35);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(146, 20);
            this.textBoxFirstName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(168, 194);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(146, 20);
            this.textBoxAge.TabIndex = 23;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 383);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelWages);
            this.Controls.Add(this.labelSpetialization);
            this.Controls.Add(this.labelThirdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRecomendations);
            this.Controls.Add(this.textBoxDiagnosis);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelWages;
        private System.Windows.Forms.Label labelSpetialization;
        private System.Windows.Forms.Label labelThirdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRecomendations;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}