using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    public partial class MainWindow : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandOrder = new SqlCommand("", DBConnection.sqlConnection);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Thread threadOrder = new Thread(OrdersFill);
            threadOrder.Start();
            MainMenuConstraint(AuthorizationFrom.userRole);
        }
        public void MainMenuConstraint(int userRole)   //загрузка формы с разрешениями для пользователей
        {
            switch (userRole)
            {
                case 1:
                    msAdmin.Visible = true;
                    pbUpdate.Visible = true;
                    lblUpdate.Visible = true;
                    lblDelete.Visible = true;
                    pbDelete.Visible = true;
                    dgvOrders.Visible = true;
                    break;
                case 2:
                    pbUpdate.Visible = false;
                    lblUpdate.Visible = false;
                    lblDelete.Visible = false;
                    pbDelete.Visible = false;
                    dgvOrders.Visible = false;
                    break;
                case 3:
                    pbUpdate.Visible = true;
                    lblUpdate.Visible = true;
                    lblDelete.Visible = true;
                    pbDelete.Visible = true;
                    dgvOrders.Visible = true;
                    break;
            }
        }
        private void OrdersFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTOrders.Clear();
                    dbTables.DTOrderFill();
                    dbTables.dependency.OnChange += ChangeOrder;

                    dgvOrders.DataSource = dbTables.DTOrders;
                    dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrders.Columns[0].Width = 30;
                    dgvOrders.Columns[0].HeaderText = "№ п/п";
                    dgvOrders.Columns[1].HeaderText = "Описание";
                    dgvOrders.Columns[1].Width = 250;
                    dgvOrders.Columns[2].HeaderText = "Дата заказа";
                    dgvOrders.Columns[3].HeaderText = "Статус заказа";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeOrder(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                OrdersFill();
        }

        public void pbAdd_Click(object sender, EventArgs e)
        {
            DynamicObjects dynamicObjects = new DynamicObjects();
            dynamicObjects.NewCreateOrderCreate();
        }
        private void cmiExitProfile_Click(object sender, EventArgs e)    //выход из профиля
        {
            switch (AuthorizationFrom.userRole)
            {
                case 1:
                    pbUpdate.Visible = false;
                    lblUpdate.Visible = false;
                    lblDelete.Visible = false;
                    pbDelete.Visible = false;
                    dgvOrders.Visible = false;
                    break;
                case 2:
                    pbUpdate.Visible = false;
                    lblUpdate.Visible = false;
                    lblDelete.Visible = false;
                    pbDelete.Visible = false;
                    dgvOrders.Visible = false;
                    break;
                case 3:
                    pbUpdate.Visible = false;
                    lblUpdate.Visible = false;
                    lblDelete.Visible = false;
                    pbDelete.Visible = false;
                    dgvOrders.Visible = false;
                    break;
                
            }
            Hide();
            AuthorizationFrom autFm = new AuthorizationFrom();
            autFm.Show();
            AuthorizationFrom.userRole = 0;
        }

        private void заврешитьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            заврешитьРаботуToolStripMenuItem_Click(sender, e);
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            switch (AuthorizationFrom.userRole)
            {
                case 1:
                    users.btnInsert.Enabled = true;
                    users.btnUpdate.Enabled = true;
                    users.btnDelete.Enabled = true;
                    break;
                            }
            users.Show(this);
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {

        }
    }
}