
namespace SUBDLab1
{
    partial class FormLab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorLabale = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearOfReleaseLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateOfReadingLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.DateOfAppearanceInTheLibraryLabel = new System.Windows.Forms.Label();
            this.SourceOfAppearanceLabel = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BindingFormatLabel = new System.Windows.Forms.Label();
            this.CoverHeightLabel = new System.Windows.Forms.Label();
            this.CoverWidthLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отркытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfManufactureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverWidthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoverHeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingFormatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceOfAppearanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfAppearanceInTheLibraryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReadingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(19, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(89, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Название книги";
            // 
            // AuthorLabale
            // 
            this.AuthorLabale.AutoSize = true;
            this.AuthorLabale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthorLabale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorLabale.ForeColor = System.Drawing.Color.Black;
            this.AuthorLabale.Location = new System.Drawing.Point(63, 82);
            this.AuthorLabale.Name = "AuthorLabale";
            this.AuthorLabale.Size = new System.Drawing.Size(45, 13);
            this.AuthorLabale.TabIndex = 4;
            this.AuthorLabale.Text = "Авторы";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenreLabel.ForeColor = System.Drawing.Color.Black;
            this.GenreLabel.Location = new System.Drawing.Point(72, 108);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Жанр";
            // 
            // YearOfReleaseLable
            // 
            this.YearOfReleaseLable.AutoSize = true;
            this.YearOfReleaseLable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YearOfReleaseLable.ForeColor = System.Drawing.Color.Black;
            this.YearOfReleaseLable.Location = new System.Drawing.Point(37, 134);
            this.YearOfReleaseLable.Name = "YearOfReleaseLable";
            this.YearOfReleaseLable.Size = new System.Drawing.Size(71, 13);
            this.YearOfReleaseLable.TabIndex = 6;
            this.YearOfReleaseLable.Text = "Год выпуска";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.FindTextBox);
            this.groupBox1.Controls.Add(this.FindButton);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.DateOfReadingLabel);
            this.groupBox1.Controls.Add(this.RatingLabel);
            this.groupBox1.Controls.Add(this.DateOfAppearanceInTheLibraryLabel);
            this.groupBox1.Controls.Add(this.SourceOfAppearanceLabel);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.BindingFormatLabel);
            this.groupBox1.Controls.Add(this.CoverHeightLabel);
            this.groupBox1.Controls.Add(this.CoverWidthLabel);
            this.groupBox1.Controls.Add(this.YearOfReleaseLable);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.GenreLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.AuthorLabale);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 271);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "покупка",
            "подарок",
            "наследство"});
            this.comboBox2.Location = new System.Drawing.Point(405, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "мягкий",
            "твердый"});
            this.comboBox1.Location = new System.Drawing.Point(405, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(405, 131);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 29;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(405, 105);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 28;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Location = new System.Drawing.Point(405, 215);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Удалить строку";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(405, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateOfReadingLabel
            // 
            this.DateOfReadingLabel.AutoSize = true;
            this.DateOfReadingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateOfReadingLabel.ForeColor = System.Drawing.Color.Black;
            this.DateOfReadingLabel.Location = new System.Drawing.Point(311, 134);
            this.DateOfReadingLabel.Name = "DateOfReadingLabel";
            this.DateOfReadingLabel.Size = new System.Drawing.Size(88, 13);
            this.DateOfReadingLabel.TabIndex = 24;
            this.DateOfReadingLabel.Text = "Дата прочтения";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RatingLabel.ForeColor = System.Drawing.Color.Black;
            this.RatingLabel.Location = new System.Drawing.Point(351, 160);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(48, 13);
            this.RatingLabel.TabIndex = 23;
            this.RatingLabel.Text = "Рейтинг";
            this.RatingLabel.Click += new System.EventHandler(this.RatingLabel_Click);
            // 
            // DateOfAppearanceInTheLibraryLabel
            // 
            this.DateOfAppearanceInTheLibraryLabel.AutoSize = true;
            this.DateOfAppearanceInTheLibraryLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateOfAppearanceInTheLibraryLabel.ForeColor = System.Drawing.Color.Black;
            this.DateOfAppearanceInTheLibraryLabel.Location = new System.Drawing.Point(238, 108);
            this.DateOfAppearanceInTheLibraryLabel.Name = "DateOfAppearanceInTheLibraryLabel";
            this.DateOfAppearanceInTheLibraryLabel.Size = new System.Drawing.Size(161, 13);
            this.DateOfAppearanceInTheLibraryLabel.TabIndex = 22;
            this.DateOfAppearanceInTheLibraryLabel.Text = "Дата появления в библиотеке";
            // 
            // SourceOfAppearanceLabel
            // 
            this.SourceOfAppearanceLabel.AutoSize = true;
            this.SourceOfAppearanceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SourceOfAppearanceLabel.ForeColor = System.Drawing.Color.Black;
            this.SourceOfAppearanceLabel.Location = new System.Drawing.Point(287, 82);
            this.SourceOfAppearanceLabel.Name = "SourceOfAppearanceLabel";
            this.SourceOfAppearanceLabel.Size = new System.Drawing.Size(112, 13);
            this.SourceOfAppearanceLabel.TabIndex = 21;
            this.SourceOfAppearanceLabel.Text = "Источник появления";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(405, 157);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(114, 183);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // BindingFormatLabel
            // 
            this.BindingFormatLabel.AutoSize = true;
            this.BindingFormatLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BindingFormatLabel.ForeColor = System.Drawing.Color.Black;
            this.BindingFormatLabel.Location = new System.Drawing.Point(297, 56);
            this.BindingFormatLabel.Name = "BindingFormatLabel";
            this.BindingFormatLabel.Size = new System.Drawing.Size(105, 13);
            this.BindingFormatLabel.TabIndex = 9;
            this.BindingFormatLabel.Text = "Формат переплета";
            this.BindingFormatLabel.Click += new System.EventHandler(this.BindingFormatLabel_Click);
            // 
            // CoverHeightLabel
            // 
            this.CoverHeightLabel.AutoSize = true;
            this.CoverHeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoverHeightLabel.ForeColor = System.Drawing.Color.Black;
            this.CoverHeightLabel.Location = new System.Drawing.Point(16, 186);
            this.CoverHeightLabel.Name = "CoverHeightLabel";
            this.CoverHeightLabel.Size = new System.Drawing.Size(92, 13);
            this.CoverHeightLabel.TabIndex = 8;
            this.CoverHeightLabel.Text = "Высота обложки";
            // 
            // CoverWidthLabel
            // 
            this.CoverWidthLabel.AutoSize = true;
            this.CoverWidthLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoverWidthLabel.ForeColor = System.Drawing.Color.Black;
            this.CoverWidthLabel.Location = new System.Drawing.Point(15, 160);
            this.CoverWidthLabel.Name = "CoverWidthLabel";
            this.CoverWidthLabel.Size = new System.Drawing.Size(93, 13);
            this.CoverWidthLabel.TabIndex = 7;
            this.CoverWidthLabel.Text = "Ширина обложки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отркытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // отркытьToolStripMenuItem
            // 
            this.отркытьToolStripMenuItem.Name = "отркытьToolStripMenuItem";
            this.отркытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отркытьToolStripMenuItem.Text = "Отркыть";
            this.отркытьToolStripMenuItem.Click += new System.EventHandler(this.отркытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.Authors,
            this.GenreColumn,
            this.YearOfManufactureColumn,
            this.CoverWidthColumn,
            this.CoverHeightColumn,
            this.BindingFormatColumn,
            this.SourceOfAppearanceColumn,
            this.DateOfAppearanceInTheLibraryColumn,
            this.DateOfReadingColumn,
            this.RatingColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(10, 280);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(300, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(1336, 257);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(511, 189);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 20);
            this.FindButton.TabIndex = 32;
            this.FindButton.Text = "button1";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(511, 215);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(100, 20);
            this.FindTextBox.TabIndex = 33;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            // 
            // Authors
            // 
            this.Authors.HeaderText = "Авторы";
            this.Authors.Name = "Authors";
            // 
            // GenreColumn
            // 
            this.GenreColumn.HeaderText = "Жанр";
            this.GenreColumn.Name = "GenreColumn";
            // 
            // YearOfManufactureColumn
            // 
            this.YearOfManufactureColumn.HeaderText = "Год выпуска";
            this.YearOfManufactureColumn.Name = "YearOfManufactureColumn";
            // 
            // CoverWidthColumn
            // 
            this.CoverWidthColumn.HeaderText = "Ширина обложки";
            this.CoverWidthColumn.Name = "CoverWidthColumn";
            // 
            // CoverHeightColumn
            // 
            this.CoverHeightColumn.HeaderText = "Высота обложки";
            this.CoverHeightColumn.Name = "CoverHeightColumn";
            // 
            // BindingFormatColumn
            // 
            this.BindingFormatColumn.HeaderText = "Формат переплета";
            this.BindingFormatColumn.Name = "BindingFormatColumn";
            // 
            // SourceOfAppearanceColumn
            // 
            this.SourceOfAppearanceColumn.HeaderText = "Источник появления";
            this.SourceOfAppearanceColumn.Name = "SourceOfAppearanceColumn";
            // 
            // DateOfAppearanceInTheLibraryColumn
            // 
            this.DateOfAppearanceInTheLibraryColumn.HeaderText = "Дата появления в библиотеке";
            this.DateOfAppearanceInTheLibraryColumn.Name = "DateOfAppearanceInTheLibraryColumn";
            // 
            // DateOfReadingColumn
            // 
            this.DateOfReadingColumn.HeaderText = " Дата прочтения";
            this.DateOfReadingColumn.Name = "DateOfReadingColumn";
            // 
            // RatingColumn
            // 
            this.RatingColumn.HeaderText = "Рейтинг";
            this.RatingColumn.Name = "RatingColumn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(767, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 95);
            this.listBox1.TabIndex = 34;
            // 
            // FormLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1172, 1080);
            this.MinimumSize = new System.Drawing.Size(1172, 590);
            this.Name = "FormLab";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLab_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AuthorLabale;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label YearOfReleaseLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DateOfReadingLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label DateOfAppearanceInTheLibraryLabel;
        private System.Windows.Forms.Label SourceOfAppearanceLabel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label BindingFormatLabel;
        private System.Windows.Forms.Label CoverHeightLabel;
        private System.Windows.Forms.Label CoverWidthLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отркытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfManufactureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoverWidthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoverHeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BindingFormatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceOfAppearanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppearanceInTheLibraryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfReadingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

