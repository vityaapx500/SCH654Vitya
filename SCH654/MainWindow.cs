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
                    dgvOrders.Columns[0].Visible = false;
                    dgvOrders.Columns[1].Visible = false;
                    dgvOrders.Columns[2].HeaderText = "Предмет";
                    dgvOrders.Columns[3].HeaderText = "Описание";
                    dgvOrders.Columns[3].Width = 250;
                    dgvOrders.Columns[4].HeaderText = "Дата заказа";
                    dgvOrders.Columns[5].HeaderText = "Статус заказа";
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
    }
}
