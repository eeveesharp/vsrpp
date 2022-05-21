namespace lab7
{
    partial class DataForm
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
            this.textBoxCpu = new System.Windows.Forms.TextBox();
            this.textBoxRam = new System.Windows.Forms.TextBox();
            this.textBoxGpu = new System.Windows.Forms.TextBox();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.buttonSetData = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCpu
            // 
            this.textBoxCpu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCpu.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCpu.Location = new System.Drawing.Point(155, 43);
            this.textBoxCpu.Multiline = true;
            this.textBoxCpu.Name = "textBoxCpu";
            this.textBoxCpu.Size = new System.Drawing.Size(128, 37);
            this.textBoxCpu.TabIndex = 0;
            this.textBoxCpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRam
            // 
            this.textBoxRam.Location = new System.Drawing.Point(155, 126);
            this.textBoxRam.Multiline = true;
            this.textBoxRam.Name = "textBoxRam";
            this.textBoxRam.Size = new System.Drawing.Size(128, 37);
            this.textBoxRam.TabIndex = 1;
            this.textBoxRam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGpu
            // 
            this.textBoxGpu.Location = new System.Drawing.Point(155, 286);
            this.textBoxGpu.Multiline = true;
            this.textBoxGpu.Name = "textBoxGpu";
            this.textBoxGpu.Size = new System.Drawing.Size(128, 37);
            this.textBoxGpu.TabIndex = 3;
            this.textBoxGpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.BackColor = System.Drawing.SystemColors.Control;
            this.labelCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCPU.Location = new System.Drawing.Point(196, 9);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(47, 22);
            this.labelCPU.TabIndex = 4;
            this.labelCPU.Text = "CPU";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRAM.Location = new System.Drawing.Point(195, 92);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(48, 20);
            this.labelRAM.TabIndex = 5;
            this.labelRAM.Text = "RAM";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(195, 172);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(52, 20);
            this.labelColor.TabIndex = 6;
            this.labelColor.Text = "Цвет";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGPU.Location = new System.Drawing.Point(196, 253);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(47, 20);
            this.labelGPU.TabIndex = 7;
            this.labelGPU.Text = "GPU";
            // 
            // buttonSetData
            // 
            this.buttonSetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetData.Location = new System.Drawing.Point(137, 353);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(166, 30);
            this.buttonSetData.TabIndex = 8;
            this.buttonSetData.Text = "Ввести";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(155, 206);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(128, 21);
            this.comboBoxColor.TabIndex = 9;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(165, 326);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(109, 13);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "Заполните все поля";
            this.labelError.Visible = false;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab7.Properties.Resources.original_5791219640c088286e8ba349_5a42e2c908749;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 395);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonSetData);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.textBoxGpu);
            this.Controls.Add(this.textBoxRam);
            this.Controls.Add(this.textBoxCpu);
            this.Name = "DataForm";
            this.Text = "Компьютер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCpu;
        private System.Windows.Forms.TextBox textBoxRam;
        private System.Windows.Forms.TextBox textBoxGpu;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Button buttonSetData;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelError;
    }
}