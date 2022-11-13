namespace laba8.Forms
{
    partial class AuthForm
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
            this.radioButtonAdministratorForAuth = new System.Windows.Forms.RadioButton();
            this.radioButtonUserForAuth = new System.Windows.Forms.RadioButton();
            this.textBoxPasswordForAuth = new System.Windows.Forms.TextBox();
            this.comboBoxSecondNameForAuth = new System.Windows.Forms.ComboBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAdministratorForAuth
            // 
            this.radioButtonAdministratorForAuth.AutoSize = true;
            this.radioButtonAdministratorForAuth.Location = new System.Drawing.Point(76, 74);
            this.radioButtonAdministratorForAuth.Name = "radioButtonAdministratorForAuth";
            this.radioButtonAdministratorForAuth.Size = new System.Drawing.Size(104, 17);
            this.radioButtonAdministratorForAuth.TabIndex = 0;
            this.radioButtonAdministratorForAuth.TabStop = true;
            this.radioButtonAdministratorForAuth.Text = "Администратор";
            this.radioButtonAdministratorForAuth.UseVisualStyleBackColor = true;
            this.radioButtonAdministratorForAuth.CheckedChanged += new System.EventHandler(this.radioButtonAdministratorForAuth_CheckedChanged);
            // 
            // radioButtonUserForAuth
            // 
            this.radioButtonUserForAuth.AutoSize = true;
            this.radioButtonUserForAuth.Location = new System.Drawing.Point(76, 121);
            this.radioButtonUserForAuth.Name = "radioButtonUserForAuth";
            this.radioButtonUserForAuth.Size = new System.Drawing.Size(98, 17);
            this.radioButtonUserForAuth.TabIndex = 1;
            this.radioButtonUserForAuth.TabStop = true;
            this.radioButtonUserForAuth.Text = "Пользователь";
            this.radioButtonUserForAuth.UseVisualStyleBackColor = true;
            this.radioButtonUserForAuth.CheckedChanged += new System.EventHandler(this.radioButtonUserForAuth_CheckedChanged);
            // 
            // textBoxPasswordForAuth
            // 
            this.textBoxPasswordForAuth.Location = new System.Drawing.Point(215, 120);
            this.textBoxPasswordForAuth.Name = "textBoxPasswordForAuth";
            this.textBoxPasswordForAuth.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordForAuth.TabIndex = 2;
            this.textBoxPasswordForAuth.Visible = false;
            // 
            // comboBoxSecondNameForAuth
            // 
            this.comboBoxSecondNameForAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondNameForAuth.FormattingEnabled = true;
            this.comboBoxSecondNameForAuth.Location = new System.Drawing.Point(215, 74);
            this.comboBoxSecondNameForAuth.Name = "comboBoxSecondNameForAuth";
            this.comboBoxSecondNameForAuth.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSecondNameForAuth.TabIndex = 3;
            this.comboBoxSecondNameForAuth.Visible = false;
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Location = new System.Drawing.Point(159, 179);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(91, 28);
            this.buttonSingIn.TabIndex = 4;
            this.buttonSingIn.Text = "Вход";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.comboBoxSecondNameForAuth);
            this.Controls.Add(this.textBoxPasswordForAuth);
            this.Controls.Add(this.radioButtonUserForAuth);
            this.Controls.Add(this.radioButtonAdministratorForAuth);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAdministratorForAuth;
        private System.Windows.Forms.RadioButton radioButtonUserForAuth;
        private System.Windows.Forms.TextBox textBoxPasswordForAuth;
        private System.Windows.Forms.ComboBox comboBoxSecondNameForAuth;
        private System.Windows.Forms.Button buttonSingIn;
    }
}