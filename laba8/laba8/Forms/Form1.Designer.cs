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
            this.radioButtonDesktop = new System.Windows.Forms.RadioButton();
            this.radioButtonNotebook = new System.Windows.Forms.RadioButton();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.buttonChangeYear = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxComputer
            // 
            this.listBoxComputer.FormattingEnabled = true;
            this.listBoxComputer.Location = new System.Drawing.Point(251, 25);
            this.listBoxComputer.Name = "listBoxComputer";
            this.listBoxComputer.Size = new System.Drawing.Size(764, 173);
            this.listBoxComputer.TabIndex = 0;
            this.listBoxComputer.SelectedIndexChanged += new System.EventHandler(this.listBoxComputer_SelectedIndexChanged);
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
            // radioButtonDesktop
            // 
            this.radioButtonDesktop.AutoSize = true;
            this.radioButtonDesktop.Location = new System.Drawing.Point(6, 63);
            this.radioButtonDesktop.Name = "radioButtonDesktop";
            this.radioButtonDesktop.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDesktop.TabIndex = 1;
            this.radioButtonDesktop.Text = "Десктоп";
            this.radioButtonDesktop.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotebook
            // 
            this.radioButtonNotebook.AutoSize = true;
            this.radioButtonNotebook.Checked = true;
            this.radioButtonNotebook.Location = new System.Drawing.Point(6, 28);
            this.radioButtonNotebook.Name = "radioButtonNotebook";
            this.radioButtonNotebook.Size = new System.Drawing.Size(66, 17);
            this.radioButtonNotebook.TabIndex = 0;
            this.radioButtonNotebook.TabStop = true;
            this.radioButtonNotebook.Text = "Ноутбук";
            this.radioButtonNotebook.UseVisualStyleBackColor = true;
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
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(375, 220);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(125, 23);
            this.buttonShowData.TabIndex = 4;
            this.buttonShowData.Text = "Просмотреть данные";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // buttonChangeYear
            // 
            this.buttonChangeYear.Location = new System.Drawing.Point(619, 220);
            this.buttonChangeYear.Name = "buttonChangeYear";
            this.buttonChangeYear.Size = new System.Drawing.Size(125, 25);
            this.buttonChangeYear.TabIndex = 5;
            this.buttonChangeYear.Text = "Изменить год";
            this.buttonChangeYear.UseVisualStyleBackColor = true;
            this.buttonChangeYear.Click += new System.EventHandler(this.buttonChangeYear_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(890, 221);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(125, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Скопировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 265);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonChangeYear);
            this.Controls.Add(this.buttonShowData);
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
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Button buttonChangeYear;
        private System.Windows.Forms.Button buttonCopy;
    }
}

