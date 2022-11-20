namespace laba8.Forms
{
    partial class InformationForm
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
            this.labelSecondNameInfo = new System.Windows.Forms.Label();
            this.labelAgeInfo = new System.Windows.Forms.Label();
            this.labelPasswordInfo = new System.Windows.Forms.Label();
            this.labelRoleInfo = new System.Windows.Forms.Label();
            this.textBoxSecondNameInfo = new System.Windows.Forms.TextBox();
            this.textBoxAgeInfo = new System.Windows.Forms.TextBox();
            this.textBoxPasswordInfo = new System.Windows.Forms.TextBox();
            this.buttonChangeAdminInfo = new System.Windows.Forms.Button();
            this.buttonOkInformation = new System.Windows.Forms.Button();
            this.comboBoxRoleInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSecondNameInfo
            // 
            this.labelSecondNameInfo.AutoSize = true;
            this.labelSecondNameInfo.Location = new System.Drawing.Point(71, 58);
            this.labelSecondNameInfo.Name = "labelSecondNameInfo";
            this.labelSecondNameInfo.Size = new System.Drawing.Size(56, 13);
            this.labelSecondNameInfo.TabIndex = 0;
            this.labelSecondNameInfo.Text = "Фамилия";
            // 
            // labelAgeInfo
            // 
            this.labelAgeInfo.AutoSize = true;
            this.labelAgeInfo.Location = new System.Drawing.Point(71, 97);
            this.labelAgeInfo.Name = "labelAgeInfo";
            this.labelAgeInfo.Size = new System.Drawing.Size(49, 13);
            this.labelAgeInfo.TabIndex = 1;
            this.labelAgeInfo.Text = "Возраст";
            // 
            // labelPasswordInfo
            // 
            this.labelPasswordInfo.AutoSize = true;
            this.labelPasswordInfo.Location = new System.Drawing.Point(71, 138);
            this.labelPasswordInfo.Name = "labelPasswordInfo";
            this.labelPasswordInfo.Size = new System.Drawing.Size(45, 13);
            this.labelPasswordInfo.TabIndex = 2;
            this.labelPasswordInfo.Text = "Пароль";
            // 
            // labelRoleInfo
            // 
            this.labelRoleInfo.AutoSize = true;
            this.labelRoleInfo.Location = new System.Drawing.Point(71, 176);
            this.labelRoleInfo.Name = "labelRoleInfo";
            this.labelRoleInfo.Size = new System.Drawing.Size(32, 13);
            this.labelRoleInfo.TabIndex = 3;
            this.labelRoleInfo.Text = "Роль";
            // 
            // textBoxSecondNameInfo
            // 
            this.textBoxSecondNameInfo.Location = new System.Drawing.Point(140, 58);
            this.textBoxSecondNameInfo.Name = "textBoxSecondNameInfo";
            this.textBoxSecondNameInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondNameInfo.TabIndex = 4;
            // 
            // textBoxAgeInfo
            // 
            this.textBoxAgeInfo.Location = new System.Drawing.Point(140, 94);
            this.textBoxAgeInfo.Name = "textBoxAgeInfo";
            this.textBoxAgeInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxAgeInfo.TabIndex = 5;
            // 
            // textBoxPasswordInfo
            // 
            this.textBoxPasswordInfo.Location = new System.Drawing.Point(140, 138);
            this.textBoxPasswordInfo.Name = "textBoxPasswordInfo";
            this.textBoxPasswordInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordInfo.TabIndex = 6;
            // 
            // buttonChangeAdminInfo
            // 
            this.buttonChangeAdminInfo.Location = new System.Drawing.Point(17, 246);
            this.buttonChangeAdminInfo.Name = "buttonChangeAdminInfo";
            this.buttonChangeAdminInfo.Size = new System.Drawing.Size(110, 23);
            this.buttonChangeAdminInfo.TabIndex = 8;
            this.buttonChangeAdminInfo.Text = "Изменить данные";
            this.buttonChangeAdminInfo.UseVisualStyleBackColor = true;
            this.buttonChangeAdminInfo.Click += new System.EventHandler(this.buttonChangeAdminInfo_Click);
            // 
            // buttonOkInformation
            // 
            this.buttonOkInformation.Location = new System.Drawing.Point(217, 246);
            this.buttonOkInformation.Name = "buttonOkInformation";
            this.buttonOkInformation.Size = new System.Drawing.Size(100, 23);
            this.buttonOkInformation.TabIndex = 9;
            this.buttonOkInformation.Text = "Ок";
            this.buttonOkInformation.UseVisualStyleBackColor = true;
            this.buttonOkInformation.Click += new System.EventHandler(this.buttonOkInformation_Click);
            // 
            // comboBoxRoleInfo
            // 
            this.comboBoxRoleInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoleInfo.FormattingEnabled = true;
            this.comboBoxRoleInfo.Items.AddRange(new object[] {
            "Chief",
            "Accountant",
            "SalesDepartment"});
            this.comboBoxRoleInfo.Location = new System.Drawing.Point(140, 176);
            this.comboBoxRoleInfo.Name = "comboBoxRoleInfo";
            this.comboBoxRoleInfo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRoleInfo.TabIndex = 10;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 281);
            this.Controls.Add(this.comboBoxRoleInfo);
            this.Controls.Add(this.buttonOkInformation);
            this.Controls.Add(this.buttonChangeAdminInfo);
            this.Controls.Add(this.textBoxPasswordInfo);
            this.Controls.Add(this.textBoxAgeInfo);
            this.Controls.Add(this.textBoxSecondNameInfo);
            this.Controls.Add(this.labelRoleInfo);
            this.Controls.Add(this.labelPasswordInfo);
            this.Controls.Add(this.labelAgeInfo);
            this.Controls.Add(this.labelSecondNameInfo);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecondNameInfo;
        private System.Windows.Forms.Label labelAgeInfo;
        private System.Windows.Forms.Label labelPasswordInfo;
        private System.Windows.Forms.Label labelRoleInfo;
        private System.Windows.Forms.TextBox textBoxSecondNameInfo;
        private System.Windows.Forms.TextBox textBoxAgeInfo;
        private System.Windows.Forms.TextBox textBoxPasswordInfo;
        private System.Windows.Forms.Button buttonChangeAdminInfo;
        private System.Windows.Forms.Button buttonOkInformation;
        private System.Windows.Forms.ComboBox comboBoxRoleInfo;
    }
}