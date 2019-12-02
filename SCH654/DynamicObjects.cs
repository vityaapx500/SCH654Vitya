using System;
using System.Windows.Forms;

namespace SCH654
{
    class DynamicObjects
    {
        DataManipulation dataManipulation = new DataManipulation();
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
        string[] orderStatus = new string[] { "Не принят", "В обработке", "Готов к выдаче" };

        public void NewCreateOrderCreate()
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
            cbStatus.SelectedIndex = -1;
            cbStatus.Items.AddRange(orderStatus);
            btnMakeOrder.Text = "Сделать заказ";
            btnMakeOrder.Dock = DockStyle.Top;
            btnMakeOrder.Click += dataManipulation.AddOrder;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.fmCreateOrder.Close();
        }
    }
}
