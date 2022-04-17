namespace lab6
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
            this.components = new System.ComponentModel.Container();
            this.textBoxMainText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFontName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAllToLowe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAllToUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAsSentences = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.FindPage = new System.Windows.Forms.TabPage();
            this.buttonForFind = new System.Windows.Forms.Button();
            this.radioButtonWithoutRegister = new System.Windows.Forms.RadioButton();
            this.radioButtonWithRegistre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForFindPage = new System.Windows.Forms.TextBox();
            this.ReplacePage = new System.Windows.Forms.TabPage();
            this.radioButtonForReplaceWithoutRegister = new System.Windows.Forms.RadioButton();
            this.radioButtonForReplaceWithRegister = new System.Windows.Forms.RadioButton();
            this.buttonForReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForReplaceSecondWord = new System.Windows.Forms.TextBox();
            this.textBoxForReplaceFirstWord = new System.Windows.Forms.TextBox();
            this.DeletePage = new System.Windows.Forms.TabPage();
            this.radioButtonForDeleteWithoutRegister = new System.Windows.Forms.RadioButton();
            this.radioButtonForDeleteWithRegister = new System.Windows.Forms.RadioButton();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.textBoxForDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxforLiteral = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelQuantitySymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFontName = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.FindPage.SuspendLayout();
            this.ReplacePage.SuspendLayout();
            this.DeletePage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMainText
            // 
            this.textBoxMainText.Location = new System.Drawing.Point(306, 27);
            this.textBoxMainText.Multiline = true;
            this.textBoxMainText.Name = "textBoxMainText";
            this.textBoxMainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMainText.Size = new System.Drawing.Size(380, 212);
            this.textBoxMainText.TabIndex = 0;
            this.textBoxMainText.TextChanged += new System.EventHandler(this.textBoxMainText_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFont,
            this.toolStripMenuRegister,
            this.ToolStripMenuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFont
            // 
            this.toolStripMenuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFontName,
            this.toolStripMenuFontSize});
            this.toolStripMenuFont.Image = global::lab6.Properties.Resources.font1;
            this.toolStripMenuFont.Name = "toolStripMenuFont";
            this.toolStripMenuFont.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuFont.Text = "Шрифт";
            // 
            // toolStripMenuFontName
            // 
            this.toolStripMenuFontName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxFontName});
            this.toolStripMenuFontName.Name = "toolStripMenuFontName";
            this.toolStripMenuFontName.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuFontName.Text = "Наименование";
            // 
            // toolStripComboBoxFontName
            // 
            this.toolStripComboBoxFontName.Name = "toolStripComboBoxFontName";
            this.toolStripComboBoxFontName.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxFontName.Text = "default";
            this.toolStripComboBoxFontName.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFontName_SelectedIndexChanged);
            // 
            // toolStripMenuFontSize
            // 
            this.toolStripMenuFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxFontSize});
            this.toolStripMenuFontSize.Name = "toolStripMenuFontSize";
            this.toolStripMenuFontSize.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuFontSize.Text = "Размер";
            // 
            // toolStripComboBoxFontSize
            // 
            this.toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
            this.toolStripComboBoxFontSize.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxFontSize.Text = "8";
            this.toolStripComboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFontSize_SelectedIndexChanged_1);
            // 
            // toolStripMenuRegister
            // 
            this.toolStripMenuRegister.Checked = true;
            this.toolStripMenuRegister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAllToLowe,
            this.toolStripMenuAllToUpper,
            this.toolStripMenuAsSentences});
            this.toolStripMenuRegister.Image = global::lab6.Properties.Resources.register;
            this.toolStripMenuRegister.Name = "toolStripMenuRegister";
            this.toolStripMenuRegister.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuRegister.Text = "Регистр";
            // 
            // toolStripMenuAllToLowe
            // 
            this.toolStripMenuAllToLowe.CheckOnClick = true;
            this.toolStripMenuAllToLowe.Name = "toolStripMenuAllToLowe";
            this.toolStripMenuAllToLowe.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuAllToLowe.Text = "Прописные";
            this.toolStripMenuAllToLowe.Click += new System.EventHandler(this.toolStripMenuAllToLowe_Click);
            // 
            // toolStripMenuAllToUpper
            // 
            this.toolStripMenuAllToUpper.CheckOnClick = true;
            this.toolStripMenuAllToUpper.Name = "toolStripMenuAllToUpper";
            this.toolStripMenuAllToUpper.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuAllToUpper.Text = "Заглавные";
            this.toolStripMenuAllToUpper.Click += new System.EventHandler(this.toolStripMenuAllToUpper_Click);
            // 
            // toolStripMenuAsSentences
            // 
            this.toolStripMenuAsSentences.CheckOnClick = true;
            this.toolStripMenuAsSentences.Name = "toolStripMenuAsSentences";
            this.toolStripMenuAsSentences.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuAsSentences.Text = "Как в предложении";
            this.toolStripMenuAsSentences.Click += new System.EventHandler(this.toolStripMenuAsSentences_Click);
            // 
            // ToolStripMenuInfo
            // 
            this.ToolStripMenuInfo.Image = global::lab6.Properties.Resources.information;
            this.ToolStripMenuInfo.Name = "ToolStripMenuInfo";
            this.ToolStripMenuInfo.Size = new System.Drawing.Size(109, 20);
            this.ToolStripMenuInfo.Text = "Информация";
            this.ToolStripMenuInfo.Click += new System.EventHandler(this.ToolStripMenuInfo_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.FindPage);
            this.TabControl.Controls.Add(this.ReplacePage);
            this.TabControl.Controls.Add(this.DeletePage);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(0, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(304, 215);
            this.TabControl.TabIndex = 2;
            // 
            // FindPage
            // 
            this.FindPage.Controls.Add(this.buttonForFind);
            this.FindPage.Controls.Add(this.radioButtonWithoutRegister);
            this.FindPage.Controls.Add(this.radioButtonWithRegistre);
            this.FindPage.Controls.Add(this.label3);
            this.FindPage.Controls.Add(this.textBoxForFindPage);
            this.FindPage.Location = new System.Drawing.Point(4, 22);
            this.FindPage.Name = "FindPage";
            this.FindPage.Padding = new System.Windows.Forms.Padding(3);
            this.FindPage.Size = new System.Drawing.Size(296, 189);
            this.FindPage.TabIndex = 0;
            this.FindPage.Text = "Найти";
            this.FindPage.UseVisualStyleBackColor = true;
            // 
            // buttonForFind
            // 
            this.buttonForFind.Location = new System.Drawing.Point(209, 128);
            this.buttonForFind.Name = "buttonForFind";
            this.buttonForFind.Size = new System.Drawing.Size(57, 21);
            this.buttonForFind.TabIndex = 4;
            this.buttonForFind.Text = "Find";
            this.buttonForFind.UseVisualStyleBackColor = true;
            this.buttonForFind.Click += new System.EventHandler(this.buttonForFind_Click);
            // 
            // radioButtonWithoutRegister
            // 
            this.radioButtonWithoutRegister.AutoSize = true;
            this.radioButtonWithoutRegister.Location = new System.Drawing.Point(57, 96);
            this.radioButtonWithoutRegister.Name = "radioButtonWithoutRegister";
            this.radioButtonWithoutRegister.Size = new System.Drawing.Size(123, 17);
            this.radioButtonWithoutRegister.TabIndex = 3;
            this.radioButtonWithoutRegister.TabStop = true;
            this.radioButtonWithoutRegister.Text = "Без учета регистра";
            this.radioButtonWithoutRegister.UseVisualStyleBackColor = true;
            // 
            // radioButtonWithRegistre
            // 
            this.radioButtonWithRegistre.AutoSize = true;
            this.radioButtonWithRegistre.Location = new System.Drawing.Point(57, 66);
            this.radioButtonWithRegistre.Name = "radioButtonWithRegistre";
            this.radioButtonWithRegistre.Size = new System.Drawing.Size(119, 17);
            this.radioButtonWithRegistre.TabIndex = 2;
            this.radioButtonWithRegistre.TabStop = true;
            this.radioButtonWithRegistre.Text = "С учетом регистра";
            this.radioButtonWithRegistre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 60);
            this.label3.TabIndex = 1;
            this.label3.Text = "С каким словом желаете найти предложение?";
            // 
            // textBoxForFindPage
            // 
            this.textBoxForFindPage.Location = new System.Drawing.Point(18, 129);
            this.textBoxForFindPage.Name = "textBoxForFindPage";
            this.textBoxForFindPage.Size = new System.Drawing.Size(185, 20);
            this.textBoxForFindPage.TabIndex = 0;
            // 
            // ReplacePage
            // 
            this.ReplacePage.Controls.Add(this.radioButtonForReplaceWithoutRegister);
            this.ReplacePage.Controls.Add(this.radioButtonForReplaceWithRegister);
            this.ReplacePage.Controls.Add(this.buttonForReplace);
            this.ReplacePage.Controls.Add(this.label2);
            this.ReplacePage.Controls.Add(this.label1);
            this.ReplacePage.Controls.Add(this.textBoxForReplaceSecondWord);
            this.ReplacePage.Controls.Add(this.textBoxForReplaceFirstWord);
            this.ReplacePage.Location = new System.Drawing.Point(4, 22);
            this.ReplacePage.Name = "ReplacePage";
            this.ReplacePage.Padding = new System.Windows.Forms.Padding(3);
            this.ReplacePage.Size = new System.Drawing.Size(296, 189);
            this.ReplacePage.TabIndex = 1;
            this.ReplacePage.Text = "Заменить";
            this.ReplacePage.UseVisualStyleBackColor = true;
            // 
            // radioButtonForReplaceWithoutRegister
            // 
            this.radioButtonForReplaceWithoutRegister.AutoSize = true;
            this.radioButtonForReplaceWithoutRegister.Location = new System.Drawing.Point(88, 103);
            this.radioButtonForReplaceWithoutRegister.Name = "radioButtonForReplaceWithoutRegister";
            this.radioButtonForReplaceWithoutRegister.Size = new System.Drawing.Size(123, 17);
            this.radioButtonForReplaceWithoutRegister.TabIndex = 6;
            this.radioButtonForReplaceWithoutRegister.TabStop = true;
            this.radioButtonForReplaceWithoutRegister.Text = "Без учета регистра";
            this.radioButtonForReplaceWithoutRegister.UseVisualStyleBackColor = true;
            // 
            // radioButtonForReplaceWithRegister
            // 
            this.radioButtonForReplaceWithRegister.AutoSize = true;
            this.radioButtonForReplaceWithRegister.Location = new System.Drawing.Point(88, 80);
            this.radioButtonForReplaceWithRegister.Name = "radioButtonForReplaceWithRegister";
            this.radioButtonForReplaceWithRegister.Size = new System.Drawing.Size(119, 17);
            this.radioButtonForReplaceWithRegister.TabIndex = 5;
            this.radioButtonForReplaceWithRegister.TabStop = true;
            this.radioButtonForReplaceWithRegister.Text = "С учетом регистра";
            this.radioButtonForReplaceWithRegister.UseVisualStyleBackColor = true;
            // 
            // buttonForReplace
            // 
            this.buttonForReplace.Location = new System.Drawing.Point(233, 162);
            this.buttonForReplace.Name = "buttonForReplace";
            this.buttonForReplace.Size = new System.Drawing.Size(57, 21);
            this.buttonForReplace.TabIndex = 4;
            this.buttonForReplace.Text = "Replace";
            this.buttonForReplace.UseVisualStyleBackColor = true;
            this.buttonForReplace.Click += new System.EventHandler(this.buttonForReplace_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово на какое изменить";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Слово для замены";
            // 
            // textBoxForReplaceSecondWord
            // 
            this.textBoxForReplaceSecondWord.Location = new System.Drawing.Point(59, 162);
            this.textBoxForReplaceSecondWord.Name = "textBoxForReplaceSecondWord";
            this.textBoxForReplaceSecondWord.Size = new System.Drawing.Size(168, 20);
            this.textBoxForReplaceSecondWord.TabIndex = 1;
            // 
            // textBoxForReplaceFirstWord
            // 
            this.textBoxForReplaceFirstWord.Location = new System.Drawing.Point(59, 43);
            this.textBoxForReplaceFirstWord.Name = "textBoxForReplaceFirstWord";
            this.textBoxForReplaceFirstWord.Size = new System.Drawing.Size(168, 20);
            this.textBoxForReplaceFirstWord.TabIndex = 0;
            // 
            // DeletePage
            // 
            this.DeletePage.Controls.Add(this.radioButtonForDeleteWithoutRegister);
            this.DeletePage.Controls.Add(this.radioButtonForDeleteWithRegister);
            this.DeletePage.Controls.Add(this.buttonDeleteWord);
            this.DeletePage.Controls.Add(this.textBoxForDelete);
            this.DeletePage.Controls.Add(this.label4);
            this.DeletePage.Location = new System.Drawing.Point(4, 22);
            this.DeletePage.Name = "DeletePage";
            this.DeletePage.Padding = new System.Windows.Forms.Padding(3);
            this.DeletePage.Size = new System.Drawing.Size(296, 189);
            this.DeletePage.TabIndex = 2;
            this.DeletePage.Text = "Удалить";
            this.DeletePage.UseVisualStyleBackColor = true;
            // 
            // radioButtonForDeleteWithoutRegister
            // 
            this.radioButtonForDeleteWithoutRegister.AutoSize = true;
            this.radioButtonForDeleteWithoutRegister.Location = new System.Drawing.Point(69, 95);
            this.radioButtonForDeleteWithoutRegister.Name = "radioButtonForDeleteWithoutRegister";
            this.radioButtonForDeleteWithoutRegister.Size = new System.Drawing.Size(123, 17);
            this.radioButtonForDeleteWithoutRegister.TabIndex = 4;
            this.radioButtonForDeleteWithoutRegister.TabStop = true;
            this.radioButtonForDeleteWithoutRegister.Text = "Без учета регистра";
            this.radioButtonForDeleteWithoutRegister.UseVisualStyleBackColor = true;
            // 
            // radioButtonForDeleteWithRegister
            // 
            this.radioButtonForDeleteWithRegister.AutoSize = true;
            this.radioButtonForDeleteWithRegister.Location = new System.Drawing.Point(69, 62);
            this.radioButtonForDeleteWithRegister.Name = "radioButtonForDeleteWithRegister";
            this.radioButtonForDeleteWithRegister.Size = new System.Drawing.Size(119, 17);
            this.radioButtonForDeleteWithRegister.TabIndex = 3;
            this.radioButtonForDeleteWithRegister.TabStop = true;
            this.radioButtonForDeleteWithRegister.Text = "С учетом регистра";
            this.radioButtonForDeleteWithRegister.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.Location = new System.Drawing.Point(194, 138);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(76, 20);
            this.buttonDeleteWord.TabIndex = 2;
            this.buttonDeleteWord.Text = "delete";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // textBoxForDelete
            // 
            this.textBoxForDelete.Location = new System.Drawing.Point(49, 138);
            this.textBoxForDelete.Name = "textBoxForDelete";
            this.textBoxForDelete.Size = new System.Drawing.Size(139, 20);
            this.textBoxForDelete.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Какое слово желаете удалить?";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxforLiteral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 189);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Вхождение литерала";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(108, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Укажите символ";
            // 
            // textBoxforLiteral
            // 
            this.textBoxforLiteral.Location = new System.Drawing.Point(132, 70);
            this.textBoxforLiteral.Name = "textBoxforLiteral";
            this.textBoxforLiteral.Size = new System.Drawing.Size(100, 20);
            this.textBoxforLiteral.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelQuantitySymbol,
            this.toolStripStatusLabelFontName});
            this.statusStrip.Location = new System.Drawing.Point(0, 247);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelQuantitySymbol
            // 
            this.toolStripStatusLabelQuantitySymbol.Name = "toolStripStatusLabelQuantitySymbol";
            this.toolStripStatusLabelQuantitySymbol.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabelQuantitySymbol.Text = "Кол-во сиволов: 0";
            // 
            // toolStripStatusLabelFontName
            // 
            this.toolStripStatusLabelFontName.Name = "toolStripStatusLabelFontName";
            this.toolStripStatusLabelFontName.Size = new System.Drawing.Size(222, 17);
            this.toolStripStatusLabelFontName.Text = "Текущий шрифт:  \"Microsoft Sans Serif\"";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCut,
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemInsert});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // toolStripMenuItemCut
            // 
            this.toolStripMenuItemCut.Name = "toolStripMenuItemCut";
            this.toolStripMenuItemCut.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemCut.Text = "Вырезать";
            this.toolStripMenuItemCut.Click += new System.EventHandler(this.toolStripMenuItemCut_Click);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemCopy.Text = "Копировать";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemInsert
            // 
            this.toolStripMenuItemInsert.Name = "toolStripMenuItemInsert";
            this.toolStripMenuItemInsert.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemInsert.Text = "Вставить";
            this.toolStripMenuItemInsert.Click += new System.EventHandler(this.toolStripMenuItemInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 269);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.textBoxMainText);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.FindPage.ResumeLayout(false);
            this.FindPage.PerformLayout();
            this.ReplacePage.ResumeLayout(false);
            this.ReplacePage.PerformLayout();
            this.DeletePage.ResumeLayout(false);
            this.DeletePage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage FindPage;
        private System.Windows.Forms.TabPage ReplacePage;
        private System.Windows.Forms.TabPage DeletePage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForFindPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxForReplaceSecondWord;
        private System.Windows.Forms.TextBox textBoxForReplaceFirstWord;
        private System.Windows.Forms.TextBox textBoxForDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonWithoutRegister;
        private System.Windows.Forms.RadioButton radioButtonWithRegistre;
        private System.Windows.Forms.Button buttonForFind;
        private System.Windows.Forms.Button buttonForReplace;
        private System.Windows.Forms.Button buttonDeleteWord;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFontName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFontSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFontName;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFontSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRegister;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAllToLowe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAllToUpper;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAsSentences;
        private System.Windows.Forms.RadioButton radioButtonForReplaceWithoutRegister;
        private System.Windows.Forms.RadioButton radioButtonForReplaceWithRegister;
        private System.Windows.Forms.RadioButton radioButtonForDeleteWithoutRegister;
        private System.Windows.Forms.RadioButton radioButtonForDeleteWithRegister;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelQuantitySymbol;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFontName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxforLiteral;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInsert;
    }
}

