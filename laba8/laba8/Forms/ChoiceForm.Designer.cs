namespace laba8.Forms
{
    partial class ChoiceForm
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
            this.buttonAdminInformation = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminInformation
            // 
            this.buttonAdminInformation.Location = new System.Drawing.Point(110, 96);
            this.buttonAdminInformation.Name = "buttonAdminInformation";
            this.buttonAdminInformation.Size = new System.Drawing.Size(149, 40);
            this.buttonAdminInformation.TabIndex = 0;
            this.buttonAdminInformation.Text = "Личные данные";
            this.buttonAdminInformation.UseVisualStyleBackColor = true;
            this.buttonAdminInformation.Click += new System.EventHandler(this.buttonAdminInformation_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(110, 172);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(149, 40);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Товары";
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Работа с данными";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonAdminInformation);
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminInformation;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button button3;
    }
}