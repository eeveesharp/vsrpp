namespace laba8.Forms
{
    partial class DesktopFormChange
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
            this.buttonSetData = new System.Windows.Forms.Button();
            this.comboBoxNumberOfCores = new System.Windows.Forms.ComboBox();
            this.labelNumberOfCore = new System.Windows.Forms.Label();
            this.labelWorkHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantityRAM = new System.Windows.Forms.TextBox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelPowerBlock = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.comboBoxGPU = new System.Windows.Forms.ComboBox();
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeBody = new System.Windows.Forms.ComboBox();
            this.textBoxBP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerForDesk = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetData
            // 
            this.buttonSetData.Location = new System.Drawing.Point(434, 384);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(85, 23);
            this.buttonSetData.TabIndex = 29;
            this.buttonSetData.Text = "Подтвердить";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // comboBoxNumberOfCores
            // 
            this.comboBoxNumberOfCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberOfCores.Enabled = false;
            this.comboBoxNumberOfCores.FormattingEnabled = true;
            this.comboBoxNumberOfCores.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.comboBoxNumberOfCores.Location = new System.Drawing.Point(286, 85);
            this.comboBoxNumberOfCores.Name = "comboBoxNumberOfCores";
            this.comboBoxNumberOfCores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumberOfCores.TabIndex = 28;
            // 
            // labelNumberOfCore
            // 
            this.labelNumberOfCore.AutoSize = true;
            this.labelNumberOfCore.Location = new System.Drawing.Point(176, 88);
            this.labelNumberOfCore.Name = "labelNumberOfCore";
            this.labelNumberOfCore.Size = new System.Drawing.Size(93, 13);
            this.labelNumberOfCore.TabIndex = 27;
            this.labelNumberOfCore.Text = "Количество ядер";
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.Location = new System.Drawing.Point(189, 256);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(70, 13);
            this.labelWorkHours.TabIndex = 25;
            this.labelWorkHours.Text = "Тип корпуса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "GB";
            // 
            // textBoxQuantityRAM
            // 
            this.textBoxQuantityRAM.Location = new System.Drawing.Point(286, 212);
            this.textBoxQuantityRAM.Name = "textBoxQuantityRAM";
            this.textBoxQuantityRAM.ReadOnly = true;
            this.textBoxQuantityRAM.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantityRAM.TabIndex = 22;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(95, 215);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(174, 13);
            this.labelRAM.TabIndex = 21;
            this.labelRAM.Text = "Количество оперативной памяти";
            // 
            // labelPowerBlock
            // 
            this.labelPowerBlock.AutoSize = true;
            this.labelPowerBlock.Location = new System.Drawing.Point(169, 172);
            this.labelPowerBlock.Name = "labelPowerBlock";
            this.labelPowerBlock.Size = new System.Drawing.Size(76, 13);
            this.labelPowerBlock.TabIndex = 20;
            this.labelPowerBlock.Text = "Блок питания";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Location = new System.Drawing.Point(206, 131);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(67, 13);
            this.labelGPU.TabIndex = 19;
            this.labelGPU.Text = "Видеокарта";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(206, 48);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(63, 13);
            this.labelCPU.TabIndex = 18;
            this.labelCPU.Text = "Процессор";
            // 
            // comboBoxGPU
            // 
            this.comboBoxGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPU.Enabled = false;
            this.comboBoxGPU.FormattingEnabled = true;
            this.comboBoxGPU.Items.AddRange(new object[] {
            "nvidia",
            "AMD"});
            this.comboBoxGPU.Location = new System.Drawing.Point(286, 128);
            this.comboBoxGPU.Name = "comboBoxGPU";
            this.comboBoxGPU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGPU.TabIndex = 16;
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCPU.Enabled = false;
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Items.AddRange(new object[] {
            "Intel",
            "AMD"});
            this.comboBoxCPU.Location = new System.Drawing.Point(286, 45);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCPU.TabIndex = 15;
            // 
            // comboBoxTypeBody
            // 
            this.comboBoxTypeBody.AutoCompleteCustomSource.AddRange(new string[] {
            "Mini Tower",
            "Mid Tower",
            "Full Tower",
            "Super Tower",
            "Ultra Tower",
            "HTPC"});
            this.comboBoxTypeBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeBody.FormattingEnabled = true;
            this.comboBoxTypeBody.Items.AddRange(new object[] {
            "SFF",
            "Mini Tower",
            "Mid Tower",
            "Full Tower"});
            this.comboBoxTypeBody.Location = new System.Drawing.Point(286, 253);
            this.comboBoxTypeBody.Name = "comboBoxTypeBody";
            this.comboBoxTypeBody.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeBody.TabIndex = 30;
            // 
            // textBoxBP
            // 
            this.textBoxBP.Location = new System.Drawing.Point(286, 169);
            this.textBoxBP.Name = "textBoxBP";
            this.textBoxBP.ReadOnly = true;
            this.textBoxBP.Size = new System.Drawing.Size(121, 20);
            this.textBoxBP.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Вт";
            // 
            // datePickerForDesk
            // 
            this.datePickerForDesk.Enabled = false;
            this.datePickerForDesk.Location = new System.Drawing.Point(286, 299);
            this.datePickerForDesk.Name = "datePickerForDesk";
            this.datePickerForDesk.Size = new System.Drawing.Size(200, 20);
            this.datePickerForDesk.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Дата";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(286, 336);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Цена";
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Location = new System.Drawing.Point(23, 384);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeData.TabIndex = 37;
            this.buttonChangeData.Text = "Изменить";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(255, 384);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DesktopFormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 419);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChangeData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerForDesk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBP);
            this.Controls.Add(this.comboBoxTypeBody);
            this.Controls.Add(this.buttonSetData);
            this.Controls.Add(this.comboBoxNumberOfCores);
            this.Controls.Add(this.labelNumberOfCore);
            this.Controls.Add(this.labelWorkHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantityRAM);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelPowerBlock);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.comboBoxGPU);
            this.Controls.Add(this.comboBoxCPU);
            this.Name = "DesktopFormChange";
            this.Text = "DesktopForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetData;
        private System.Windows.Forms.ComboBox comboBoxNumberOfCores;
        private System.Windows.Forms.Label labelNumberOfCore;
        private System.Windows.Forms.Label labelWorkHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantityRAM;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelPowerBlock;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.ComboBox comboBoxGPU;
        private System.Windows.Forms.ComboBox comboBoxCPU;
        private System.Windows.Forms.ComboBox comboBoxTypeBody;
        private System.Windows.Forms.TextBox textBoxBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerForDesk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.Button buttonDelete;
    }   
}