namespace lab7
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
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEnterData.Location = new System.Drawing.Point(162, 47);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(210, 34);
            this.buttonEnterData.TabIndex = 0;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonShowData.Location = new System.Drawing.Point(162, 111);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(210, 32);
            this.buttonShowData.TabIndex = 1;
            this.buttonShowData.Text = "Посмотреть данные";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab7.Properties.Resources.original_5791219640c088286e8ba349_5a42e2c908749;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 218);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonEnterData);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Button buttonShowData;
    }
}

