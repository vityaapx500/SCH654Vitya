using System;
using System.Windows.Forms;

namespace SCH654
{
    class DynamicObjects
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        MainWindow mainWindow = new MainWindow();
        Form fmCreateOrder = new Form();
        Label lblOrder = new Label();
        public TextBox tbOrder = new TextBox();
        Label lblDateOrder = new Label();
        public TextBox tbDateOrder = new TextBox();
        Label lblStatus = new Label();
        public ComboBox cbStatus = new ComboBox();
        Button btnMakeOrder = new Button();
        Button btnCancel = new Button();
        public Form parentCteate = new Form();

        public void NewCreateOrderCreate() //Создание динамической формы Офомление заказа
        {

            fmCreateOrder.Text = "Новый заказ";
            fmCreateOrder.StartPosition = FormStartPosition.CenterScreen;
            fmCreateOrder.FormBorderStyle = FormBorderStyle.FixedDialog;
            fmCreateOrder.Size = new System.Drawing.Size(250, 260);
            lblOrder.Text = "Содержание заказа";
            lblOrder.Dock = DockStyle.Top;
            tbOrder.Multiline = true;
            tbOrder.Height = 60;
            tbOrder.Dock = DockStyle.Top;
            tbDateOrder.Enabled = false;
            tbDateOrder.Dock = DockStyle.Top;
            lblDateOrder.Text = "Дата заказа";
            lblDateOrder.Dock = DockStyle.Top;
            tbDateOrder.Text = DateTime.Now.ToString("MM.dd.yyyy");
            lblStatus.Text = "Статус заказа";
            lblStatus.Dock = DockStyle.Top;
            cbStatus.Dock = DockStyle.Top;
            cbStatus.Items.AddRange(new object[] {"В обработке", "Готов к выдаче" } );
            cbStatus.SelectedIndex = 0;
            cbStatus.Enabled = false;
            btnMakeOrder.Text = "Сделать заказ";
            btnMakeOrder.Dock = DockStyle.Top;
            btnMakeOrder.Click += AddOrder;
            btnCancel.Dock = DockStyle.Top;
            btnCancel.Text = "Отмена";
            btnCancel.Click += btnCancel_Click;

            fmCreateOrder.Controls.Add(btnCancel);
            fmCreateOrder.Controls.Add(btnMakeOrder);
            fmCreateOrder.Controls.Add(cbStatus);
            fmCreateOrder.Controls.Add(lblStatus);
            fmCreateOrder.Controls.Add(tbDateOrder);
            fmCreateOrder.Controls.Add(lblDateOrder);
            fmCreateOrder.Controls.Add(tbOrder);
            fmCreateOrder.Controls.Add(lblOrder);
            fmCreateOrder.Show(parentCteate);

        }
        private void btnCancel_Click(object sender, EventArgs e) //Кнопка Закрыть
        {
            this.fmCreateOrder.Close();
        }

        //Процедуры манипулирования данными
        public void AddOrder(object sender, EventArgs e) //Добаление заказа
        {
            try
            {
                storedProcedure.SPOrderInsert(tbOrder.Text, tbDateOrder.Text, cbStatus.SelectedItem.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void UpdateOrder(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        storedProcedure.SPOrderUpdate(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value.ToString()), tbSurname.Text, tbName.Text, tbPantronymic.Text, Convert.ToDateTime(tbDateBirth.Text),
        //    Convert.ToInt32(tbNumUdostov.Text), tbNameUchilisha.Text, Convert.ToDateTime(tbDateOkonch.Text), tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbDolj.SelectedIndex));
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Ошибка при изменении данных");
        //    }
        //    tbSurname.Clear();
        //    tbName.Clear();
        //    tbPantronymic.Clear();
        //    tbDateBirth.Clear();
        //    tbNumUdostov.Clear();
        //    tbNameUchilisha.Clear();
        //    tbDateOkonch.Clear();
        //    tbLogin.Clear();
        //    tbPassword.Clear();
        //    cbDolj.SelectedValue = -1;
        //}

        public void DeleteOrder(object sender, EventArgs e) //добавление заказа
        {
            //MessageBox.Show("Вы действительно желаете удалить заказ " + tbOrder.Text + " от " + tbDateOrder.Text + "?", "Удаления заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //try
            //{
            //    storedProcedure.SPOrderDelete(Convert.ToInt32(mainWindow.dgvOrders.CurrentRow.Cells[0].Value.ToString()));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
