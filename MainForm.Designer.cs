namespace Lab4
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSingers = new System.Windows.Forms.TabPage();
            this.tabPageSongs = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewSingers = new System.Windows.Forms.DataGridView();
            this.bindingSourceSingers = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesingerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label0 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonMakeSong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.bindingSourceSongs = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songPerformersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonGetReport1 = new System.Windows.Forms.Button();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonGetReport2 = new System.Windows.Forms.Button();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageSingers.SuspendLayout();
            this.tabPageSongs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSingers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSongs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSingers);
            this.tabControl1.Controls.Add(this.tabPageSongs);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(67, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSingers
            // 
            this.tabPageSingers.Controls.Add(this.dataGridViewSingers);
            this.tabPageSingers.Controls.Add(this.buttonDelete);
            this.tabPageSingers.Controls.Add(this.buttonUpdate);
            this.tabPageSingers.Controls.Add(this.buttonAdd);
            this.tabPageSingers.Location = new System.Drawing.Point(4, 25);
            this.tabPageSingers.Name = "tabPageSingers";
            this.tabPageSingers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingers.Size = new System.Drawing.Size(1042, 621);
            this.tabPageSingers.TabIndex = 0;
            this.tabPageSingers.Text = "Артисты";
            this.tabPageSingers.UseVisualStyleBackColor = true;
            // 
            // tabPageSongs
            // 
            this.tabPageSongs.Controls.Add(this.dataGridViewSongs);
            this.tabPageSongs.Controls.Add(this.button2);
            this.tabPageSongs.Controls.Add(this.button1);
            this.tabPageSongs.Controls.Add(this.buttonMakeSong);
            this.tabPageSongs.Location = new System.Drawing.Point(4, 25);
            this.tabPageSongs.Name = "tabPageSongs";
            this.tabPageSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSongs.Size = new System.Drawing.Size(1042, 621);
            this.tabPageSongs.TabIndex = 1;
            this.tabPageSongs.Text = "Песни";
            this.tabPageSongs.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewReport1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1042, 621);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчёт1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewReport2);
            this.tabPage4.Controls.Add(this.buttonGetReport2);
            this.tabPage4.Controls.Add(this.numericUpDown2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1042, 621);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчёт2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(249, 6);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(357, 7);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(467, 7);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewSingers
            // 
            this.dataGridViewSingers.AutoGenerateColumns = false;
            this.dataGridViewSingers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namesingerDataGridViewTextBoxColumn,
            this.subscriptionCostDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.label0});
            this.dataGridViewSingers.DataSource = this.bindingSourceSingers;
            this.dataGridViewSingers.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewSingers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSingers.Name = "dataGridViewSingers";
            this.dataGridViewSingers.RowHeadersWidth = 51;
            this.dataGridViewSingers.RowTemplate.Height = 24;
            this.dataGridViewSingers.Size = new System.Drawing.Size(1040, 570);
            this.dataGridViewSingers.TabIndex = 3;
            // 
            // bindingSourceSingers
            // 
            this.bindingSourceSingers.DataSource = typeof(Interfaces.DTO.SingersDto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // namesingerDataGridViewTextBoxColumn
            // 
            this.namesingerDataGridViewTextBoxColumn.DataPropertyName = "Name_singer";
            this.namesingerDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.namesingerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesingerDataGridViewTextBoxColumn.Name = "namesingerDataGridViewTextBoxColumn";
            this.namesingerDataGridViewTextBoxColumn.Width = 125;
            // 
            // subscriptionCostDataGridViewTextBoxColumn
            // 
            this.subscriptionCostDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionCost";
            this.subscriptionCostDataGridViewTextBoxColumn.HeaderText = "Цена подписки";
            this.subscriptionCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subscriptionCostDataGridViewTextBoxColumn.Name = "subscriptionCostDataGridViewTextBoxColumn";
            this.subscriptionCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // label0
            // 
            this.label0.DataPropertyName = "Label_ID";
            this.label0.HeaderText = "Лейбл";
            this.label0.MinimumWidth = 6;
            this.label0.Name = "label0";
            this.label0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.label0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.label0.Width = 125;
            // 
            // buttonMakeSong
            // 
            this.buttonMakeSong.Location = new System.Drawing.Point(12, 7);
            this.buttonMakeSong.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMakeSong.Name = "buttonMakeSong";
            this.buttonMakeSong.Size = new System.Drawing.Size(100, 28);
            this.buttonMakeSong.TabIndex = 0;
            this.buttonMakeSong.Text = "Песня";
            this.buttonMakeSong.UseVisualStyleBackColor = true;
            this.buttonMakeSong.Click += new System.EventHandler(this.buttonMakeSong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить песню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.AutoGenerateColumns = false;
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.songDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.songPerformersDataGridViewTextBoxColumn});
            this.dataGridViewSongs.DataSource = this.bindingSourceSongs;
            this.dataGridViewSongs.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewSongs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.RowHeadersWidth = 51;
            this.dataGridViewSongs.RowTemplate.Height = 24;
            this.dataGridViewSongs.Size = new System.Drawing.Size(1037, 564);
            this.dataGridViewSongs.TabIndex = 3;
            // 
            // bindingSourceSongs
            // 
            this.bindingSourceSongs.DataSource = typeof(Interfaces.DTO.SongsDto);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // songDataGridViewTextBoxColumn
            // 
            this.songDataGridViewTextBoxColumn.DataPropertyName = "Song";
            this.songDataGridViewTextBoxColumn.HeaderText = "Название песни";
            this.songDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songDataGridViewTextBoxColumn.Name = "songDataGridViewTextBoxColumn";
            this.songDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Подписка";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата выхода";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // songPerformersDataGridViewTextBoxColumn
            // 
            this.songPerformersDataGridViewTextBoxColumn.DataPropertyName = "SongPerformers";
            this.songPerformersDataGridViewTextBoxColumn.HeaderText = "Исполнитель (-и)";
            this.songPerformersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songPerformersDataGridViewTextBoxColumn.Name = "songPerformersDataGridViewTextBoxColumn";
            this.songPerformersDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetReport1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лейбл";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonGetReport1
            // 
            this.buttonGetReport1.Location = new System.Drawing.Point(563, 25);
            this.buttonGetReport1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetReport1.Name = "buttonGetReport1";
            this.buttonGetReport1.Size = new System.Drawing.Size(100, 28);
            this.buttonGetReport1.TabIndex = 2;
            this.buttonGetReport1.Text = "Найти";
            this.buttonGetReport1.UseVisualStyleBackColor = true;
            this.buttonGetReport1.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewReport1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.RowHeadersWidth = 51;
            this.dataGridViewReport1.RowTemplate.Height = 24;
            this.dataGridViewReport1.Size = new System.Drawing.Size(865, 500);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Песни за месяц";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 18);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(409, 16);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // buttonGetReport2
            // 
            this.buttonGetReport2.Location = new System.Drawing.Point(611, 12);
            this.buttonGetReport2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetReport2.Name = "buttonGetReport2";
            this.buttonGetReport2.Size = new System.Drawing.Size(120, 28);
            this.buttonGetReport2.TabIndex = 4;
            this.buttonGetReport2.Text = "Найти";
            this.buttonGetReport2.UseVisualStyleBackColor = true;
            this.buttonGetReport2.Click += new System.EventHandler(this.buttonGetReport2_Click);
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(16, 55);
            this.dataGridViewReport2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.RowHeadersWidth = 51;
            this.dataGridViewReport2.RowTemplate.Height = 24;
            this.dataGridViewReport2.Size = new System.Drawing.Size(1020, 560);
            this.dataGridViewReport2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSingers.ResumeLayout(false);
            this.tabPageSongs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSingers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSongs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSingers;
        private System.Windows.Forms.TabPage tabPageSongs;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewSingers;
        private System.Windows.Forms.BindingSource bindingSourceSingers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesingerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn label0;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMakeSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songPerformersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceSongs;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetReport1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Button buttonGetReport2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

