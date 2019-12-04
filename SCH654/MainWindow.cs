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

        private void MainWindow_Load(object sender, EventArgs e) //Загрузка Главной формы 
        {
            Thread threadOrder = new Thread(OrdersFill);
            Thread threadDevice = new Thread(MagazineDeviceFill);
            Thread threadStatinery = new Thread(MagazineStationeryFill);
            threadOrder.Start();
            threadDevice.Start();
            threadStatinery.Start();
            MainMenuConstraint(AuthorizationForm.userRole);
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
        private void OrdersFill() //Заполнение таблицы Заказы
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
        private void ChangeOrder(object sender, SqlNotificationEventArgs e) //Обновление таблицы Заказы
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                OrdersFill();
        }
        private void cmiExitProfile_Click(object sender, EventArgs e)    //выход из профиля
        {
            switch (AuthorizationForm.userRole)
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
            AuthorizationForm autFm = new AuthorizationForm();
            autFm.Show();
            AuthorizationForm.userRole = 0;
        }

        private void заврешитьРаботуToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка завершить работу приложения
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) //Событие зактрытия формы
        {
            заврешитьРаботуToolStripMenuItem_Click(sender, e);
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e) //Вызов формы Пользователи
        {
            Users users = new Users();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    users.btnInsert.Enabled = true;
                    users.btnUpdate.Enabled = true;
                    users.btnDelete.Enabled = true;
                    break;
                            }
            users.Show(this);
        }
        public void pbAdd_Click(object sender, EventArgs e) //Добавление заказа
        {
            DynamicObjects dynamicObjects = new DynamicObjects();
            dynamicObjects.NewCreateOrderCreate();
        }
        private void DeleteOrder(object sender, EventArgs e) //Удаление заказа
        {
            MessageBox.Show("Вы действительно желаете удалить заказ " + dgvOrders.CurrentRow.Cells[1].ToString() + " от " + dgvOrders.CurrentRow.Cells[2].ToString() + "?", "Удаления заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(DialogResult)
            {
                case (DialogResult.Yes):
                    try
                    {
                        storedProcedure.SPOrderDelete(Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value.ToString()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case (DialogResult.No):
                    break;
            }
        }

        //TabPage Журнал техники
        private void MagazineDeviceFill() //Заполнение таблицы Техника
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTMagazineDevice.Clear();
                    dbTables.DTMagazineDeviceFill();
                    dbTables.dependency.OnChange += ChangeDevice;

                    dgvDevice.DataSource = dbTables.DTMagazineDevice;
                    dgvDevice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDevice.Columns[0].HeaderText = "№ п/п";
                    dgvDevice.Columns[1].HeaderText = "Тип устройства";
                    dgvDevice.Columns[2].HeaderText = "Производитель";
                    dgvDevice.Columns[3].HeaderText = "Модель";
                    dgvDevice.Columns[4].HeaderText = "Количество";
                    dgvDevice.Columns[5].HeaderText = "Дата принятия";
                    dgvDevice.Columns[5].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeDevice(object sender, SqlNotificationEventArgs e) //Обновление таблицы Заказы
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                MagazineDeviceFill();
        }

        //TabPage Канцелярия
        private void MagazineStationeryFill() //Заполнение таблицы Техника
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTMagazineStationery.Clear();
                    dbTables.DTMagazineStationeryFill();
                    dbTables.dependency.OnChange += ChangeStationery;

                    dgvStationery.DataSource = dbTables.DTMagazineStationery;
                    dgvStationery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvStationery.Columns[0].HeaderText = "№ п/п";
                    dgvStationery.Columns[1].HeaderText = "Производитель";
                    dgvStationery.Columns[2].HeaderText = "Название";
                    dgvStationery.Columns[3].HeaderText = "Тип";
                    dgvStationery.Columns[4].HeaderText = "Количество";
                    dgvStationery.Columns[5].HeaderText = "Дата принятия";
                    dgvStationery.Columns[5].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeStationery(object sender, SqlNotificationEventArgs e) //Обновление таблицы Заказы
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                MagazineStationeryFill();
        }
    }
}