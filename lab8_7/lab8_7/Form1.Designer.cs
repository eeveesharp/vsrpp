namespace lab8_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.radioButtonPatient = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(258, 222);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(139, 31);
            this.buttonEnterData.TabIndex = 1;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(258, 268);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(139, 31);
            this.buttonGetData.TabIndex = 2;
            this.buttonGetData.Text = "Заполнить листбокс";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPatient);
            this.groupBox1.Controls.Add(this.radioButtonDoctor);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Checked = true;
            this.radioButtonDoctor.Location = new System.Drawing.Point(42, 28);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonDoctor.TabIndex = 4;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Врач";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            // 
            // radioButtonPatient
            // 
            this.radioButtonPatient.AutoSize = true;
            this.radioButtonPatient.Location = new System.Drawing.Point(42, 60);
            this.radioButtonPatient.Name = "radioButtonPatient";
            this.radioButtonPatient.Size = new System.Drawing.Size(68, 17);
            this.radioButtonPatient.TabIndex = 5;
            this.radioButtonPatient.Text = "Пациент";
            this.radioButtonPatient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPatient;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
    }
}

