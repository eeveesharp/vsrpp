namespace laba8
{
    partial class MainForm
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
            this.listBoxComputer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.radioButtonNotebook = new System.Windows.Forms.RadioButton();
            this.radioButtonDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxComputer
            // 
            this.listBoxComputer.FormattingEnabled = true;
            this.listBoxComputer.Location = new System.Drawing.Point(251, 25);
            this.listBoxComputer.Name = "listBoxComputer";
            this.listBoxComputer.Size = new System.Drawing.Size(386, 251);
            this.listBoxComputer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDesktop);
            this.groupBox1.Controls.Add(this.radioButtonNotebook);
            this.groupBox1.Location = new System.Drawing.Point(29, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите";
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(29, 46);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(200, 23);
            this.buttonEnterData.TabIndex = 2;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // radioButtonNotebook
            // 
            this.radioButtonNotebook.AutoSize = true;
            this.radioButtonNotebook.Location = new System.Drawing.Point(6, 28);
            this.radioButtonNotebook.Name = "radioButtonNotebook";
            this.radioButtonNotebook.Size = new System.Drawing.Size(66, 17);
            this.radioButtonNotebook.TabIndex = 0;
            this.radioButtonNotebook.TabStop = true;
            this.radioButtonNotebook.Text = "Ноутбук";
            this.radioButtonNotebook.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesktop
            // 
            this.radioButtonDesktop.AutoSize = true;
            this.radioButtonDesktop.Location = new System.Drawing.Point(6, 63);
            this.radioButtonDesktop.Name = "radioButtonDesktop";
            this.radioButtonDesktop.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDesktop.TabIndex = 1;
            this.radioButtonDesktop.TabStop = true;
            this.radioButtonDesktop.Text = "Десктоп";
            this.radioButtonDesktop.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 282);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxComputer);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.RadioButton radioButtonDesktop;
        private System.Windows.Forms.RadioButton radioButtonNotebook;
    }
}

