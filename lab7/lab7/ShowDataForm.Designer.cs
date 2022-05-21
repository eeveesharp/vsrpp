namespace lab7
{
    partial class ShowDataForm
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
            this.labelCpu = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelGpu = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(111, 34);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(35, 13);
            this.labelCpu.TabIndex = 0;
            this.labelCpu.Text = "label1";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(111, 67);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(35, 13);
            this.labelRam.TabIndex = 1;
            this.labelRam.Text = "label2";
            // 
            // labelGpu
            // 
            this.labelGpu.AutoSize = true;
            this.labelGpu.Location = new System.Drawing.Point(111, 98);
            this.labelGpu.Name = "labelGpu";
            this.labelGpu.Size = new System.Drawing.Size(35, 13);
            this.labelGpu.TabIndex = 2;
            this.labelGpu.Text = "label3";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(111, 125);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(35, 13);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "label4";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(114, 169);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ShowDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 208);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelGpu);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelCpu);
            this.Name = "ShowDataForm";
            this.Text = "ShowDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelGpu;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonOk;
    }
}