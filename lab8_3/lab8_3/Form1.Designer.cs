namespace lab8_3
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
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonWriteData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBird = new System.Windows.Forms.RadioButton();
            this.radioButtonMammal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.Location = new System.Drawing.Point(22, 12);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(339, 160);
            this.listBoxAnimal.TabIndex = 0;
            this.listBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimal_SelectedIndexChanged);
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(466, 144);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(120, 28);
            this.buttonEnterData.TabIndex = 1;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonWriteData
            // 
            this.buttonWriteData.Location = new System.Drawing.Point(141, 178);
            this.buttonWriteData.Name = "buttonWriteData";
            this.buttonWriteData.Size = new System.Drawing.Size(87, 23);
            this.buttonWriteData.TabIndex = 2;
            this.buttonWriteData.Text = "Заполнить";
            this.buttonWriteData.UseVisualStyleBackColor = true;
            this.buttonWriteData.Click += new System.EventHandler(this.buttonWriteData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBird);
            this.groupBox1.Controls.Add(this.radioButtonMammal);
            this.groupBox1.Location = new System.Drawing.Point(431, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите";
            // 
            // radioButtonBird
            // 
            this.radioButtonBird.AutoSize = true;
            this.radioButtonBird.Location = new System.Drawing.Point(35, 64);
            this.radioButtonBird.Name = "radioButtonBird";
            this.radioButtonBird.Size = new System.Drawing.Size(56, 17);
            this.radioButtonBird.TabIndex = 1;
            this.radioButtonBird.Text = "Птица";
            this.radioButtonBird.UseVisualStyleBackColor = true;
            // 
            // radioButtonMammal
            // 
            this.radioButtonMammal.AutoSize = true;
            this.radioButtonMammal.Checked = true;
            this.radioButtonMammal.Location = new System.Drawing.Point(35, 30);
            this.radioButtonMammal.Name = "radioButtonMammal";
            this.radioButtonMammal.Size = new System.Drawing.Size(110, 17);
            this.radioButtonMammal.TabIndex = 0;
            this.radioButtonMammal.TabStop = true;
            this.radioButtonMammal.Text = "Млекопитающее";
            this.radioButtonMammal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonWriteData);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.listBoxAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Button buttonWriteData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBird;
        private System.Windows.Forms.RadioButton radioButtonMammal;
    }
}

