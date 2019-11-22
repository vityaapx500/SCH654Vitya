namespace SCH654
{
    partial class ConnectionForm
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
            this.cbListDataBase = new System.Windows.Forms.ComboBox();
            this.lbListDataBase = new System.Windows.Forms.Label();
            this.tbPasswordServer = new System.Windows.Forms.TextBox();
            this.lbPasswordServer = new System.Windows.Forms.Label();
            this.tbUserServer = new System.Windows.Forms.TextBox();
            this.lbUserServer = new System.Windows.Forms.Label();
            this.cbNameServer = new System.Windows.Forms.ComboBox();
            this.lbNameServer = new System.Windows.Forms.Label();
            this.cbAddressServer = new System.Windows.Forms.ComboBox();
            this.lbAddressServer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.sstStatusConnection = new System.Windows.Forms.StatusStrip();
            this.lbsstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sstStatusConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbListDataBase
            // 
            this.cbListDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbListDataBase.Enabled = false;
            this.cbListDataBase.FormattingEnabled = true;
            this.cbListDataBase.Location = new System.Drawing.Point(0, 157);
            this.cbListDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.cbListDataBase.Name = "cbListDataBase";
            this.cbListDataBase.Size = new System.Drawing.Size(289, 21);
            this.cbListDataBase.TabIndex = 21;
            // 
            // lbListDataBase
            // 
            this.lbListDataBase.AutoSize = true;
            this.lbListDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbListDataBase.Font = new System.Drawing.Font("Arial", 9F);
            this.lbListDataBase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbListDataBase.Location = new System.Drawing.Point(0, 142);
            this.lbListDataBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListDataBase.Name = "lbListDataBase";
            this.lbListDataBase.Size = new System.Drawing.Size(120, 15);
            this.lbListDataBase.TabIndex = 18;
            this.lbListDataBase.Text = "Список баз данных:";
            // 
            // tbPasswordServer
            // 
            this.tbPasswordServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordServer.Enabled = false;
            this.tbPasswordServer.Location = new System.Drawing.Point(0, 122);
            this.tbPasswordServer.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswordServer.Name = "tbPasswordServer";
            this.tbPasswordServer.PasswordChar = '*';
            this.tbPasswordServer.Size = new System.Drawing.Size(289, 20);
            this.tbPasswordServer.TabIndex = 23;
            // 
            // lbPasswordServer
            // 
            this.lbPasswordServer.AutoSize = true;
            this.lbPasswordServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPasswordServer.Font = new System.Drawing.Font("Arial", 9F);
            this.lbPasswordServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPasswordServer.Location = new System.Drawing.Point(0, 107);
            this.lbPasswordServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPasswordServer.Name = "lbPasswordServer";
            this.lbPasswordServer.Size = new System.Drawing.Size(137, 15);
            this.lbPasswordServer.TabIndex = 17;
            this.lbPasswordServer.Text = "Пароль пользователя:";
            // 
            // tbUserServer
            // 
            this.tbUserServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserServer.Enabled = false;
            this.tbUserServer.Location = new System.Drawing.Point(0, 87);
            this.tbUserServer.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserServer.Name = "tbUserServer";
            this.tbUserServer.PasswordChar = '*';
            this.tbUserServer.Size = new System.Drawing.Size(289, 20);
            this.tbUserServer.TabIndex = 22;
            // 
            // lbUserServer
            // 
            this.lbUserServer.AutoSize = true;
            this.lbUserServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUserServer.Font = new System.Drawing.Font("Arial", 9F);
            this.lbUserServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUserServer.Location = new System.Drawing.Point(0, 72);
            this.lbUserServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserServer.Name = "lbUserServer";
            this.lbUserServer.Size = new System.Drawing.Size(142, 15);
            this.lbUserServer.TabIndex = 16;
            this.lbUserServer.Text = "Пользователь сервера:";
            // 
            // cbNameServer
            // 
            this.cbNameServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbNameServer.Enabled = false;
            this.cbNameServer.FormattingEnabled = true;
            this.cbNameServer.Location = new System.Drawing.Point(0, 51);
            this.cbNameServer.Margin = new System.Windows.Forms.Padding(2);
            this.cbNameServer.Name = "cbNameServer";
            this.cbNameServer.Size = new System.Drawing.Size(289, 21);
            this.cbNameServer.TabIndex = 20;
            // 
            // lbNameServer
            // 
            this.lbNameServer.AutoSize = true;
            this.lbNameServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameServer.Font = new System.Drawing.Font("Arial", 9F);
            this.lbNameServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNameServer.Location = new System.Drawing.Point(0, 36);
            this.lbNameServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameServer.Name = "lbNameServer";
            this.lbNameServer.Size = new System.Drawing.Size(116, 15);
            this.lbNameServer.TabIndex = 15;
            this.lbNameServer.Text = "Название сервера:";
            // 
            // cbAddressServer
            // 
            this.cbAddressServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAddressServer.Enabled = false;
            this.cbAddressServer.FormattingEnabled = true;
            this.cbAddressServer.Location = new System.Drawing.Point(0, 15);
            this.cbAddressServer.Margin = new System.Windows.Forms.Padding(2);
            this.cbAddressServer.Name = "cbAddressServer";
            this.cbAddressServer.Size = new System.Drawing.Size(289, 21);
            this.cbAddressServer.TabIndex = 19;
            // 
            // lbAddressServer
            // 
            this.lbAddressServer.AutoSize = true;
            this.lbAddressServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAddressServer.Font = new System.Drawing.Font("Arial", 9F);
            this.lbAddressServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAddressServer.Location = new System.Drawing.Point(0, 0);
            this.lbAddressServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddressServer.Name = "lbAddressServer";
            this.lbAddressServer.Size = new System.Drawing.Size(94, 15);
            this.lbAddressServer.TabIndex = 14;
            this.lbAddressServer.Text = "Адрес сервера:";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(0, 230);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(289, 26);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.Enabled = false;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.Location = new System.Drawing.Point(0, 204);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(289, 26);
            this.btnConnect.TabIndex = 29;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheck.Location = new System.Drawing.Point(0, 178);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(289, 26);
            this.btnCheck.TabIndex = 28;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // sstStatusConnection
            // 
            this.sstStatusConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.sstStatusConnection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstStatusConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstStatus});
            this.sstStatusConnection.Location = new System.Drawing.Point(0, 256);
            this.sstStatusConnection.Name = "sstStatusConnection";
            this.sstStatusConnection.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.sstStatusConnection.Size = new System.Drawing.Size(289, 22);
            this.sstStatusConnection.TabIndex = 31;
            this.sstStatusConnection.Text = "statusStrip1";
            // 
            // lbsstStatus
            // 
            this.lbsstStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.lbsstStatus.Name = "lbsstStatus";
            this.lbsstStatus.Size = new System.Drawing.Size(11, 17);
            this.lbsstStatus.Text = "-";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 279);
            this.Controls.Add(this.sstStatusConnection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cbListDataBase);
            this.Controls.Add(this.lbListDataBase);
            this.Controls.Add(this.tbPasswordServer);
            this.Controls.Add(this.lbPasswordServer);
            this.Controls.Add(this.tbUserServer);
            this.Controls.Add(this.lbUserServer);
            this.Controls.Add(this.cbNameServer);
            this.Controls.Add(this.lbNameServer);
            this.Controls.Add(this.cbAddressServer);
            this.Controls.Add(this.lbAddressServer);
            this.Name = "ConnectionForm";
            this.Text = "Подключение к базе данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.sstStatusConnection.ResumeLayout(false);
            this.sstStatusConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListDataBase;
        private System.Windows.Forms.Label lbListDataBase;
        private System.Windows.Forms.TextBox tbPasswordServer;
        private System.Windows.Forms.Label lbPasswordServer;
        private System.Windows.Forms.TextBox tbUserServer;
        private System.Windows.Forms.Label lbUserServer;
        private System.Windows.Forms.ComboBox cbNameServer;
        private System.Windows.Forms.Label lbNameServer;
        private System.Windows.Forms.ComboBox cbAddressServer;
        private System.Windows.Forms.Label lbAddressServer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.StatusStrip sstStatusConnection;
        private System.Windows.Forms.ToolStripStatusLabel lbsstStatus;
    }
}