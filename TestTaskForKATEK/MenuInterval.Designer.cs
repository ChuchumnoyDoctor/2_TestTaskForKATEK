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
            this.groupBoxSettingsBD = new System.Windows.Forms.GroupBox();
            this.labelPathToFile = new System.Windows.Forms.Label();
            this.labelTextPath = new System.Windows.Forms.Label();
            this.buttonChooseDT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelDataTime = new System.Windows.Forms.Panel();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.dateTimePickerDataStart = new System.Windows.Forms.DateTimePicker();
            this.buttonViborka = new System.Windows.Forms.Button();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.dateTimePickerDataEnd = new System.Windows.Forms.DateTimePicker();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageTableToDB = new System.Windows.Forms.TabPage();
            this.buttonSetToBD = new System.Windows.Forms.Button();
            this.buttonGetDocument = new System.Windows.Forms.Button();
            this.tabPageFromBDToView = new System.Windows.Forms.TabPage();
            this.buttonGetFromBDByInterval = new System.Windows.Forms.Button();
            this.buttonGetFromBD = new System.Windows.Forms.Button();
            this.groupBoxSettingsBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelDataTime.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageTableToDB.SuspendLayout();
            this.tabPageFromBDToView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettingsBD
            // 
            this.groupBoxSettingsBD.Controls.Add(this.labelPathToFile);
            this.groupBoxSettingsBD.Controls.Add(this.labelTextPath);
            this.groupBoxSettingsBD.Controls.Add(this.buttonChooseDT);
            this.groupBoxSettingsBD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxSettingsBD.Location = new System.Drawing.Point(0, 386);
            this.groupBoxSettingsBD.Name = "groupBoxSettingsBD";
            this.groupBoxSettingsBD.Size = new System.Drawing.Size(679, 65);
            this.groupBoxSettingsBD.TabIndex = 1;
            this.groupBoxSettingsBD.TabStop = false;
            this.groupBoxSettingsBD.Text = "Настройка БД";
            // 
            // labelPathToFile
            // 
            this.labelPathToFile.AutoSize = true;
            this.labelPathToFile.Location = new System.Drawing.Point(182, 41);
            this.labelPathToFile.Name = "labelPathToFile";
            this.labelPathToFile.Size = new System.Drawing.Size(0, 19);
            this.labelPathToFile.TabIndex = 2;
            // 
            // labelTextPath
            // 
            this.labelTextPath.AutoSize = true;
            this.labelTextPath.Location = new System.Drawing.Point(182, 22);
            this.labelTextPath.Name = "labelTextPath";
            this.labelTextPath.Size = new System.Drawing.Size(111, 19);
            this.labelTextPath.TabIndex = 1;
            this.labelTextPath.Text = "Выбранная БД:";
            // 
            // buttonChooseDT
            // 
            this.buttonChooseDT.Location = new System.Drawing.Point(6, 25);
            this.buttonChooseDT.Name = "buttonChooseDT";
            this.buttonChooseDT.Size = new System.Drawing.Size(170, 35);
            this.buttonChooseDT.TabIndex = 0;
            this.buttonChooseDT.Text = "Выбрать базу данных";
            this.buttonChooseDT.UseVisualStyleBackColor = true;
            this.buttonChooseDT.Click += new System.EventHandler(this.buttonChooseDT_Click);
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
            this.panelDataTime.Controls.Add(this.buttonViborka);
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
            this.dateTimePickerDataStart.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerDataStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataStart.Location = new System.Drawing.Point(47, 12);
            this.dateTimePickerDataStart.Name = "dateTimePickerDataStart";
            this.dateTimePickerDataStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDataStart.TabIndex = 8;
            // 
            // buttonViborka
            // 
            this.buttonViborka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViborka.Location = new System.Drawing.Point(499, 6);
            this.buttonViborka.Name = "buttonViborka";
            this.buttonViborka.Size = new System.Drawing.Size(170, 35);
            this.buttonViborka.TabIndex = 0;
            this.buttonViborka.Text = "Отобразить выборку";
            this.buttonViborka.UseVisualStyleBackColor = true;
            this.buttonViborka.Click += new System.EventHandler(this.buttonViborka_Click);
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
            this.dateTimePickerDataEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
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
            this.tabPageTableToDB.Controls.Add(this.buttonSetToBD);
            this.tabPageTableToDB.Controls.Add(this.buttonGetDocument);
            this.tabPageTableToDB.Location = new System.Drawing.Point(4, 28);
            this.tabPageTableToDB.Name = "tabPageTableToDB";
            this.tabPageTableToDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTableToDB.Size = new System.Drawing.Size(671, 118);
            this.tabPageTableToDB.TabIndex = 0;
            this.tabPageTableToDB.Text = "Загрузка из таблицы в БД";
            this.tabPageTableToDB.UseVisualStyleBackColor = true;
            // 
            // buttonSetToBD
            // 
            this.buttonSetToBD.Location = new System.Drawing.Point(495, 6);
            this.buttonSetToBD.Name = "buttonSetToBD";
            this.buttonSetToBD.Size = new System.Drawing.Size(170, 59);
            this.buttonSetToBD.TabIndex = 1;
            this.buttonSetToBD.Text = "Сохранить в БД";
            this.buttonSetToBD.UseVisualStyleBackColor = true;
            this.buttonSetToBD.Click += new System.EventHandler(this.buttonSetToBD_Click);
            // 
            // buttonGetDocument
            // 
            this.buttonGetDocument.Location = new System.Drawing.Point(6, 6);
            this.buttonGetDocument.Name = "buttonGetDocument";
            this.buttonGetDocument.Size = new System.Drawing.Size(170, 59);
            this.buttonGetDocument.TabIndex = 1;
            this.buttonGetDocument.Text = "Выбрать документ для загрузки";
            this.buttonGetDocument.UseVisualStyleBackColor = true;
            this.buttonGetDocument.Click += new System.EventHandler(this.buttonGetDocument_Click);
            // 
            // tabPageFromBDToView
            // 
            this.tabPageFromBDToView.Controls.Add(this.buttonGetFromBDByInterval);
            this.tabPageFromBDToView.Controls.Add(this.buttonGetFromBD);
            this.tabPageFromBDToView.Location = new System.Drawing.Point(4, 28);
            this.tabPageFromBDToView.Name = "tabPageFromBDToView";
            this.tabPageFromBDToView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFromBDToView.Size = new System.Drawing.Size(671, 118);
            this.tabPageFromBDToView.TabIndex = 1;
            this.tabPageFromBDToView.Text = "Загрузка из БД";
            this.tabPageFromBDToView.UseVisualStyleBackColor = true;
            // 
            // buttonGetFromBDByInterval
            // 
            this.buttonGetFromBDByInterval.Location = new System.Drawing.Point(425, 6);
            this.buttonGetFromBDByInterval.Name = "buttonGetFromBDByInterval";
            this.buttonGetFromBDByInterval.Size = new System.Drawing.Size(243, 59);
            this.buttonGetFromBDByInterval.TabIndex = 2;
            this.buttonGetFromBDByInterval.Text = "Показать данные всех документов с учетом интервала";
            this.buttonGetFromBDByInterval.UseVisualStyleBackColor = true;
            this.buttonGetFromBDByInterval.Click += new System.EventHandler(this.buttonGetFromBDByInterval_Click);
            // 
            // buttonGetFromBD
            // 
            this.buttonGetFromBD.Location = new System.Drawing.Point(6, 6);
            this.buttonGetFromBD.Name = "buttonGetFromBD";
            this.buttonGetFromBD.Size = new System.Drawing.Size(170, 59);
            this.buttonGetFromBD.TabIndex = 2;
            this.buttonGetFromBD.Text = "Показать загруженные документы";
            this.buttonGetFromBD.UseVisualStyleBackColor = true;
            this.buttonGetFromBD.Click += new System.EventHandler(this.buttonGetFromBD_Click);
            // 
            // MenuInterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSettingsBD);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(695, 490);
            this.Name = "MenuInterval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отображение в интервале времени";
            this.groupBoxSettingsBD.ResumeLayout(false);
            this.groupBoxSettingsBD.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxSettingsBD;
        private System.Windows.Forms.Label labelPathToFile;
        private System.Windows.Forms.Label labelTextPath;
        private System.Windows.Forms.Button buttonChooseDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelDataTime;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataStart;
        private System.Windows.Forms.Button buttonViborka;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEnd;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageTableToDB;
        private System.Windows.Forms.TabPage tabPageFromBDToView;
        private System.Windows.Forms.Button buttonSetToBD;
        private System.Windows.Forms.Button buttonGetDocument;
        private System.Windows.Forms.Button buttonGetFromBD;
        private System.Windows.Forms.Button buttonGetFromBDByInterval;
    }
}

