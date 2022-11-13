namespace laba8
{
    partial class ChangeYear
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
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxChangeYear = new System.Windows.Forms.TextBox();
            this.buttonChangeYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(50, 36);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(35, 13);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "label1";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(91, 36);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(35, 13);
            this.labelMonth.TabIndex = 1;
            this.labelMonth.Text = "label2";
            // 
            // textBoxChangeYear
            // 
            this.textBoxChangeYear.Location = new System.Drawing.Point(132, 33);
            this.textBoxChangeYear.Name = "textBoxChangeYear";
            this.textBoxChangeYear.Size = new System.Drawing.Size(49, 20);
            this.textBoxChangeYear.TabIndex = 2;
            // 
            // buttonChangeYear
            // 
            this.buttonChangeYear.Location = new System.Drawing.Point(75, 89);
            this.buttonChangeYear.Name = "buttonChangeYear";
            this.buttonChangeYear.Size = new System.Drawing.Size(81, 23);
            this.buttonChangeYear.TabIndex = 3;
            this.buttonChangeYear.Text = "Подтвердить";
            this.buttonChangeYear.UseVisualStyleBackColor = true;
            this.buttonChangeYear.Click += new System.EventHandler(this.buttonChangeYear_Click);
            // 
            // ChangeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 130);
            this.Controls.Add(this.buttonChangeYear);
            this.Controls.Add(this.textBoxChangeYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Name = "ChangeYear";
            this.Text = "ChangeYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxChangeYear;
        private System.Windows.Forms.Button buttonChangeYear;
    }
}