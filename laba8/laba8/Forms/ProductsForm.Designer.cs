namespace laba8.Forms
{
    partial class ProductsForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonAllProducts = new System.Windows.Forms.RadioButton();
            this.radioButtonAllDesktops = new System.Windows.Forms.RadioButton();
            this.radioButtonAllNotebooks = new System.Windows.Forms.RadioButton();
            this.buttonSortByDate = new System.Windows.Forms.Button();
            this.buttonSortByPrice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFindByYear = new System.Windows.Forms.Button();
            this.buttonFindByPrice = new System.Windows.Forms.Button();
            this.buttonFindByCPU = new System.Windows.Forms.Button();
            this.buttonFindByRam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(873, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonAllProducts
            // 
            this.radioButtonAllProducts.AutoSize = true;
            this.radioButtonAllProducts.Checked = true;
            this.radioButtonAllProducts.Location = new System.Drawing.Point(12, 13);
            this.radioButtonAllProducts.Name = "radioButtonAllProducts";
            this.radioButtonAllProducts.Size = new System.Drawing.Size(84, 17);
            this.radioButtonAllProducts.TabIndex = 1;
            this.radioButtonAllProducts.TabStop = true;
            this.radioButtonAllProducts.Text = "Все товары";
            this.radioButtonAllProducts.UseVisualStyleBackColor = true;
            this.radioButtonAllProducts.CheckedChanged += new System.EventHandler(this.radioButtonAllProducts_CheckedChanged);
            // 
            // radioButtonAllDesktops
            // 
            this.radioButtonAllDesktops.AutoSize = true;
            this.radioButtonAllDesktops.Location = new System.Drawing.Point(103, 13);
            this.radioButtonAllDesktops.Name = "radioButtonAllDesktops";
            this.radioButtonAllDesktops.Size = new System.Drawing.Size(69, 17);
            this.radioButtonAllDesktops.TabIndex = 2;
            this.radioButtonAllDesktops.Text = "Десктоп";
            this.radioButtonAllDesktops.UseVisualStyleBackColor = true;
            this.radioButtonAllDesktops.CheckedChanged += new System.EventHandler(this.radioButtonAllDesktops_CheckedChanged);
            // 
            // radioButtonAllNotebooks
            // 
            this.radioButtonAllNotebooks.AutoSize = true;
            this.radioButtonAllNotebooks.Location = new System.Drawing.Point(178, 13);
            this.radioButtonAllNotebooks.Name = "radioButtonAllNotebooks";
            this.radioButtonAllNotebooks.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAllNotebooks.TabIndex = 3;
            this.radioButtonAllNotebooks.Text = "Ноутбук";
            this.radioButtonAllNotebooks.UseVisualStyleBackColor = true;
            this.radioButtonAllNotebooks.CheckedChanged += new System.EventHandler(this.radioButtonAllNotebooks_CheckedChanged);
            // 
            // buttonSortByDate
            // 
            this.buttonSortByDate.Location = new System.Drawing.Point(250, 13);
            this.buttonSortByDate.Name = "buttonSortByDate";
            this.buttonSortByDate.Size = new System.Drawing.Size(131, 28);
            this.buttonSortByDate.TabIndex = 5;
            this.buttonSortByDate.Text = "Сортировка по дате";
            this.buttonSortByDate.UseVisualStyleBackColor = true;
            this.buttonSortByDate.Click += new System.EventHandler(this.buttonSortByDate_Click);
            // 
            // buttonSortByPrice
            // 
            this.buttonSortByPrice.Location = new System.Drawing.Point(387, 13);
            this.buttonSortByPrice.Name = "buttonSortByPrice";
            this.buttonSortByPrice.Size = new System.Drawing.Size(131, 28);
            this.buttonSortByPrice.TabIndex = 6;
            this.buttonSortByPrice.Text = "Сортировка по цене";
            this.buttonSortByPrice.UseVisualStyleBackColor = true;
            this.buttonSortByPrice.Click += new System.EventHandler(this.buttonSortByPrice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сортировка по блоку питания";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(13, 52);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(197, 20);
            this.textBoxFind.TabIndex = 8;
            // 
            // buttonFindByYear
            // 
            this.buttonFindByYear.Location = new System.Drawing.Point(216, 50);
            this.buttonFindByYear.Name = "buttonFindByYear";
            this.buttonFindByYear.Size = new System.Drawing.Size(91, 23);
            this.buttonFindByYear.TabIndex = 9;
            this.buttonFindByYear.Text = "Поиск по году";
            this.buttonFindByYear.UseVisualStyleBackColor = true;
            this.buttonFindByYear.Click += new System.EventHandler(this.buttonFindByYear_Click);
            // 
            // buttonFindByPrice
            // 
            this.buttonFindByPrice.Location = new System.Drawing.Point(313, 50);
            this.buttonFindByPrice.Name = "buttonFindByPrice";
            this.buttonFindByPrice.Size = new System.Drawing.Size(101, 23);
            this.buttonFindByPrice.TabIndex = 10;
            this.buttonFindByPrice.Text = "Поиск по цене";
            this.buttonFindByPrice.UseVisualStyleBackColor = true;
            this.buttonFindByPrice.Click += new System.EventHandler(this.buttonFindByPrice_Click);
            // 
            // buttonFindByCPU
            // 
            this.buttonFindByCPU.Location = new System.Drawing.Point(420, 50);
            this.buttonFindByCPU.Name = "buttonFindByCPU";
            this.buttonFindByCPU.Size = new System.Drawing.Size(104, 23);
            this.buttonFindByCPU.TabIndex = 11;
            this.buttonFindByCPU.Text = "Поиск по CPU";
            this.buttonFindByCPU.UseVisualStyleBackColor = true;
            this.buttonFindByCPU.Click += new System.EventHandler(this.buttonFindByCPU_Click);
            // 
            // buttonFindByRam
            // 
            this.buttonFindByRam.Location = new System.Drawing.Point(530, 50);
            this.buttonFindByRam.Name = "buttonFindByRam";
            this.buttonFindByRam.Size = new System.Drawing.Size(104, 23);
            this.buttonFindByRam.TabIndex = 12;
            this.buttonFindByRam.Text = "Поиск по RAM";
            this.buttonFindByRam.UseVisualStyleBackColor = true;
            this.buttonFindByRam.Click += new System.EventHandler(this.buttonFindByRam_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 368);
            this.Controls.Add(this.buttonFindByRam);
            this.Controls.Add(this.buttonFindByCPU);
            this.Controls.Add(this.buttonFindByPrice);
            this.Controls.Add(this.buttonFindByYear);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSortByPrice);
            this.Controls.Add(this.buttonSortByDate);
            this.Controls.Add(this.radioButtonAllNotebooks);
            this.Controls.Add(this.radioButtonAllDesktops);
            this.Controls.Add(this.radioButtonAllProducts);
            this.Controls.Add(this.listBox1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonAllProducts;
        private System.Windows.Forms.RadioButton radioButtonAllDesktops;
        private System.Windows.Forms.RadioButton radioButtonAllNotebooks;
        private System.Windows.Forms.Button buttonSortByDate;
        private System.Windows.Forms.Button buttonSortByPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonFindByYear;
        private System.Windows.Forms.Button buttonFindByPrice;
        private System.Windows.Forms.Button buttonFindByCPU;
        private System.Windows.Forms.Button buttonFindByRam;
    }
}