namespace SCH654
{
    partial class Users
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPantronymic = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPantronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnErrors = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.tbSearchFlitration = new System.Windows.Forms.TextBox();
            this.gbSearchFiltration = new System.Windows.Forms.GroupBox();
            this.gpManipulation = new System.Windows.Forms.GroupBox();
            this.pnCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbSearchFiltration.SuspendLayout();
            this.gpManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(3, 261);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(194, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Добавить пользователя";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(3, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Изменить пользователя";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.Location = new System.Drawing.Point(3, 227);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(194, 21);
            this.cbRole.TabIndex = 8;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRole.Location = new System.Drawing.Point(3, 214);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 25;
            this.lblRole.Text = "Роль";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfirmPassword.Location = new System.Drawing.Point(3, 194);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(194, 20);
            this.tbConfirmPassword.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 181);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Повторте пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(3, 161);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(194, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(3, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(3, 128);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(194, 20);
            this.tbLogin.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(3, 115);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Логин";
            // 
            // tbPantronymic
            // 
            this.tbPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPantronymic.Location = new System.Drawing.Point(3, 95);
            this.tbPantronymic.Name = "tbPantronymic";
            this.tbPantronymic.Size = new System.Drawing.Size(194, 20);
            this.tbPantronymic.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(3, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить пользователя";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPantronymic
            // 
            this.lblPantronymic.AutoSize = true;
            this.lblPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPantronymic.Location = new System.Drawing.Point(3, 82);
            this.lblPantronymic.Name = "lblPantronymic";
            this.lblPantronymic.Size = new System.Drawing.Size(128, 13);
            this.lblPantronymic.TabIndex = 5;
            this.lblPantronymic.Text = "Отчество пользователя";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(194, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя пользователя";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(3, 29);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(194, 20);
            this.tbSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurname.Location = new System.Drawing.Point(3, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(130, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Фамилия пользователя";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnClose);
            this.pnCancel.Controls.Add(this.btnErrors);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(200, 298);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(731, 35);
            this.pnCancel.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(659, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnErrors
            // 
            this.btnErrors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnErrors.Location = new System.Drawing.Point(0, 0);
            this.btnErrors.Name = "btnErrors";
            this.btnErrors.Size = new System.Drawing.Size(72, 35);
            this.btnErrors.TabIndex = 12;
            this.btnErrors.Text = "Ошибки";
            this.btnErrors.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Enabled = false;
            this.dgvUsers.Location = new System.Drawing.Point(200, 42);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(725, 256);
            this.dgvUsers.TabIndex = 22;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbFiltration.Location = new System.Drawing.Point(619, 16);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(109, 17);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearchFlitration
            // 
            this.tbSearchFlitration.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearchFlitration.Location = new System.Drawing.Point(3, 16);
            this.tbSearchFlitration.Name = "tbSearchFlitration";
            this.tbSearchFlitration.Size = new System.Drawing.Size(616, 20);
            this.tbSearchFlitration.TabIndex = 1;
            this.tbSearchFlitration.Text = "Введите данные поезда...";
            this.tbSearchFlitration.WordWrap = false;
            // 
            // gbSearchFiltration
            // 
            this.gbSearchFiltration.Controls.Add(this.chbFiltration);
            this.gbSearchFiltration.Controls.Add(this.tbSearchFlitration);
            this.gbSearchFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchFiltration.Location = new System.Drawing.Point(200, 0);
            this.gbSearchFiltration.Name = "gbSearchFiltration";
            this.gbSearchFiltration.Size = new System.Drawing.Size(731, 43);
            this.gbSearchFiltration.TabIndex = 19;
            this.gbSearchFiltration.TabStop = false;
            this.gbSearchFiltration.Text = "Поиск и фильтрация";
            // 
            // gpManipulation
            // 
            this.gpManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpManipulation.Controls.Add(this.btnInsert);
            this.gpManipulation.Controls.Add(this.btnUpdate);
            this.gpManipulation.Controls.Add(this.cbRole);
            this.gpManipulation.Controls.Add(this.lblRole);
            this.gpManipulation.Controls.Add(this.tbConfirmPassword);
            this.gpManipulation.Controls.Add(this.lblConfirmPassword);
            this.gpManipulation.Controls.Add(this.tbPassword);
            this.gpManipulation.Controls.Add(this.lblPassword);
            this.gpManipulation.Controls.Add(this.tbLogin);
            this.gpManipulation.Controls.Add(this.lblLogin);
            this.gpManipulation.Controls.Add(this.tbPantronymic);
            this.gpManipulation.Controls.Add(this.btnDelete);
            this.gpManipulation.Controls.Add(this.lblPantronymic);
            this.gpManipulation.Controls.Add(this.tbName);
            this.gpManipulation.Controls.Add(this.lblName);
            this.gpManipulation.Controls.Add(this.tbSurname);
            this.gpManipulation.Controls.Add(this.lblSurname);
            this.gpManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpManipulation.Location = new System.Drawing.Point(0, 0);
            this.gpManipulation.Name = "gpManipulation";
            this.gpManipulation.Size = new System.Drawing.Size(200, 333);
            this.gpManipulation.TabIndex = 21;
            this.gpManipulation.TabStop = false;
            this.gpManipulation.Text = "Манипулирование данными";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 333);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gbSearchFiltration);
            this.Controls.Add(this.gpManipulation);
            this.Name = "Users";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Users_Load);
            this.pnCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbSearchFiltration.ResumeLayout(false);
            this.gbSearchFiltration.PerformLayout();
            this.gpManipulation.ResumeLayout(false);
            this.gpManipulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPantronymic;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPantronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnErrors;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearchFlitration;
        private System.Windows.Forms.GroupBox gbSearchFiltration;
        private System.Windows.Forms.GroupBox gpManipulation;
    }
}