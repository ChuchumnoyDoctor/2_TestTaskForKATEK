namespace TestTaskForKATEK
{
    partial class MenuInterval
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelDataTime = new System.Windows.Forms.Panel();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.dateTimePickerDataStart = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.dateTimePickerDataEnd = new System.Windows.Forms.DateTimePicker();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageTableToDB = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageFromBDToView = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelDataTime.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageTableToDB.SuspendLayout();
            this.tabPageFromBDToView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка БД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к БД:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать базу данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 236);
            this.dataGridView1.TabIndex = 2;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.panelDataTime);
            this.panelSettings.Controls.Add(this.tabControlSettings);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(679, 150);
            this.panelSettings.TabIndex = 3;
            // 
            // panelDataTime
            // 
            this.panelDataTime.Controls.Add(this.labelDataStart);
            this.panelDataTime.Controls.Add(this.dateTimePickerDataStart);
            this.panelDataTime.Controls.Add(this.button3);
            this.panelDataTime.Controls.Add(this.labelDataEnd);
            this.panelDataTime.Controls.Add(this.dateTimePickerDataEnd);
            this.panelDataTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataTime.Location = new System.Drawing.Point(0, 102);
            this.panelDataTime.Name = "panelDataTime";
            this.panelDataTime.Size = new System.Drawing.Size(679, 48);
            this.panelDataTime.TabIndex = 2;
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Location = new System.Drawing.Point(10, 18);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(31, 19);
            this.labelDataStart.TabIndex = 10;
            this.labelDataStart.Text = "От:";
            // 
            // dateTimePickerDataStart
            // 
            this.dateTimePickerDataStart.CustomFormat = "dd:MM:yyyy HH:mm:ss";
            this.dateTimePickerDataStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataStart.Location = new System.Drawing.Point(47, 12);
            this.dateTimePickerDataStart.Name = "dateTimePickerDataStart";
            this.dateTimePickerDataStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDataStart.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(499, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Отобразить выборку";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Location = new System.Drawing.Point(253, 18);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(31, 19);
            this.labelDataEnd.TabIndex = 9;
            this.labelDataEnd.Text = "До:";
            // 
            // dateTimePickerDataEnd
            // 
            this.dateTimePickerDataEnd.CustomFormat = "dd:MM:yyyy HH:mm:ss";
            this.dateTimePickerDataEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataEnd.Location = new System.Drawing.Point(290, 12);
            this.dateTimePickerDataEnd.Name = "dateTimePickerDataEnd";
            this.dateTimePickerDataEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDataEnd.TabIndex = 7;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageTableToDB);
            this.tabControlSettings.Controls.Add(this.tabPageFromBDToView);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(679, 150);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPageTableToDB
            // 
            this.tabPageTableToDB.Controls.Add(this.button4);
            this.tabPageTableToDB.Controls.Add(this.button2);
            this.tabPageTableToDB.Location = new System.Drawing.Point(4, 28);
            this.tabPageTableToDB.Name = "tabPageTableToDB";
            this.tabPageTableToDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTableToDB.Size = new System.Drawing.Size(671, 118);
            this.tabPageTableToDB.TabIndex = 0;
            this.tabPageTableToDB.Text = "Загрузка из таблицы в БД";
            this.tabPageTableToDB.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 59);
            this.button4.TabIndex = 1;
            this.button4.Text = "Сохранить в БД";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выбрать документ для загрузки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPageFromBDToView
            // 
            this.tabPageFromBDToView.Controls.Add(this.button5);
            this.tabPageFromBDToView.Location = new System.Drawing.Point(4, 28);
            this.tabPageFromBDToView.Name = "tabPageFromBDToView";
            this.tabPageFromBDToView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFromBDToView.Size = new System.Drawing.Size(671, 118);
            this.tabPageFromBDToView.TabIndex = 1;
            this.tabPageFromBDToView.Text = "Загрузка из БД";
            this.tabPageFromBDToView.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 59);
            this.button5.TabIndex = 2;
            this.button5.Text = "Показать загруженные документы";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MenuInterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuInterval";
            this.Text = "Отображение в интервале времени";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelDataTime.ResumeLayout(false);
            this.panelDataTime.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageTableToDB.ResumeLayout(false);
            this.tabPageFromBDToView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelDataTime;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEnd;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageTableToDB;
        private System.Windows.Forms.TabPage tabPageFromBDToView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

