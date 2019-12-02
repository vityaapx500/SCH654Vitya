namespace SCH654
{
    partial class MainWindow
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
            this.cmsDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиИзУчётнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заврешитьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnManipulation = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.tpMagazineDevice = new System.Windows.Forms.TabPage();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.tpMagazineStationery = new System.Windows.Forms.TabPage();
            this.dgvStationery = new System.Windows.Forms.DataGridView();
            this.tcReports = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.cmsDevice.SuspendLayout();
            this.msAdmin.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            this.tpMagazineDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.tpMagazineStationery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationery)).BeginInit();
            this.tcReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDevice
            // 
            this.cmsDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выйтиИзУчётнойЗаписиToolStripMenuItem,
            this.заврешитьРаботуToolStripMenuItem});
            this.cmsDevice.Name = "cmsDevice";
            this.cmsDevice.Size = new System.Drawing.Size(214, 76);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // выйтиИзУчётнойЗаписиToolStripMenuItem
            // 
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Name = "выйтиИзУчётнойЗаписиToolStripMenuItem";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Text = "Выйти из учётной записи";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.cmiExitProfile_Click);
            // 
            // заврешитьРаботуToolStripMenuItem
            // 
            this.заврешитьРаботуToolStripMenuItem.Name = "заврешитьРаботуToolStripMenuItem";
            this.заврешитьРаботуToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.заврешитьРаботуToolStripMenuItem.Text = "Завершить работу";
            this.заврешитьРаботуToolStripMenuItem.Click += new System.EventHandler(this.заврешитьРаботуToolStripMenuItem_Click);
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(882, 24);
            this.msAdmin.TabIndex = 3;
            this.msAdmin.Text = "menuStrip1";
            this.msAdmin.Visible = false;
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ролиToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ролиToolStripMenuItem.Text = "Роли";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpOrders);
            this.tcMain.Controls.Add(this.tpMagazineDevice);
            this.tcMain.Controls.Add(this.tpMagazineStationery);
            this.tcMain.Controls.Add(this.tcReports);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(882, 469);
            this.tcMain.TabIndex = 4;
            // 
            // tpOrders
            // 
            this.tpOrders.ContextMenuStrip = this.cmsDevice;
            this.tpOrders.Controls.Add(this.dgvOrders);
            this.tpOrders.Controls.Add(this.pnManipulation);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(874, 443);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Заказы";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.ContextMenuStrip = this.cmsDevice;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 66);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(868, 374);
            this.dgvOrders.TabIndex = 20;
            // 
            // pnManipulation
            // 
            this.pnManipulation.Controls.Add(this.pbAdd);
            this.pnManipulation.Controls.Add(this.lblDelete);
            this.pnManipulation.Controls.Add(this.lblAdd);
            this.pnManipulation.Controls.Add(this.pbDelete);
            this.pnManipulation.Controls.Add(this.pbUpdate);
            this.pnManipulation.Controls.Add(this.lblUpdate);
            this.pnManipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulation.Location = new System.Drawing.Point(3, 3);
            this.pnManipulation.Name = "pnManipulation";
            this.pnManipulation.Size = new System.Drawing.Size(868, 63);
            this.pnManipulation.TabIndex = 19;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::SCH654.Properties.Resources.add;
            this.pbAdd.Location = new System.Drawing.Point(19, 2);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(24, 27);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 14;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDelete.Location = new System.Drawing.Point(137, 36);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(54, 15);
            this.lblDelete.TabIndex = 18;
            this.lblDelete.Text = "Удалить";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdd.Location = new System.Drawing.Point(7, 31);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(54, 30);
            this.lblAdd.TabIndex = 13;
            this.lblAdd.Text = "Сделать\r\nзаказ";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::SCH654.Properties.Resources.delete;
            this.pbDelete.Location = new System.Drawing.Point(151, 2);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(24, 27);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 17;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbUpdate
            // 
            this.pbUpdate.Image = global::SCH654.Properties.Resources.change;
            this.pbUpdate.Location = new System.Drawing.Point(85, 2);
            this.pbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(24, 27);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdate.TabIndex = 15;
            this.pbUpdate.TabStop = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdate.Location = new System.Drawing.Point(65, 36);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(62, 15);
            this.lblUpdate.TabIndex = 16;
            this.lblUpdate.Text = "Изменить";
            // 
            // tpMagazineDevice
            // 
            this.tpMagazineDevice.Controls.Add(this.dgvDevice);
            this.tpMagazineDevice.Location = new System.Drawing.Point(4, 22);
            this.tpMagazineDevice.Name = "tpMagazineDevice";
            this.tpMagazineDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tpMagazineDevice.Size = new System.Drawing.Size(874, 443);
            this.tpMagazineDevice.TabIndex = 1;
            this.tpMagazineDevice.Text = "Технические устройства";
            this.tpMagazineDevice.UseVisualStyleBackColor = true;
            // 
            // dgvDevice
            // 
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(3, 3);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.Size = new System.Drawing.Size(868, 437);
            this.dgvDevice.TabIndex = 4;
            // 
            // tpMagazineStationery
            // 
            this.tpMagazineStationery.Controls.Add(this.dgvStationery);
            this.tpMagazineStationery.Location = new System.Drawing.Point(4, 22);
            this.tpMagazineStationery.Name = "tpMagazineStationery";
            this.tpMagazineStationery.Size = new System.Drawing.Size(874, 443);
            this.tpMagazineStationery.TabIndex = 2;
            this.tpMagazineStationery.Text = "Кацелярские принадлежности";
            this.tpMagazineStationery.UseVisualStyleBackColor = true;
            // 
            // dgvStationery
            // 
            this.dgvStationery.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStationery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStationery.Location = new System.Drawing.Point(0, 0);
            this.dgvStationery.Name = "dgvStationery";
            this.dgvStationery.Size = new System.Drawing.Size(874, 443);
            this.dgvStationery.TabIndex = 5;
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.button1);
            this.tcReports.Location = new System.Drawing.Point(4, 22);
            this.tcReports.Name = "tcReports";
            this.tcReports.Padding = new System.Windows.Forms.Padding(3);
            this.tcReports.Size = new System.Drawing.Size(874, 443);
            this.tcReports.TabIndex = 4;
            this.tcReports.Text = "Отчёты";
            this.tcReports.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(868, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Аналитический отчёт о заказах за месяц";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(874, 443);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Настройки";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 469);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.msAdmin);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт периферийных устройств и канцелярии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cmsDevice.ResumeLayout(false);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnManipulation.ResumeLayout(false);
            this.pnManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            this.tpMagazineDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.tpMagazineStationery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationery)).EndInit();
            this.tcReports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDevice;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзУчётнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заврешитьРаботуToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnManipulation;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TabPage tpMagazineDevice;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.TabPage tpMagazineStationery;
        private System.Windows.Forms.DataGridView dgvStationery;
        private System.Windows.Forms.TabPage tcReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpSettings;
    }
}

