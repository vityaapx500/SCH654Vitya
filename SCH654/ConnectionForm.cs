using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SCH654
{
    public partial class ConnectionForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private int status = 1;
        public Thread threadGetServers;
        public Thread threadMessage;
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            switch (DBConnection.logCon)
            {
                case (true):
                    cbAddressServer.Text = Registry_Class.DataSource;
                    cbNameServer.Text = Registry_Class.DSServerName;
                    cbListDataBase.Text = Registry_Class.InitialCatalog;
                    cbAddressServer.Enabled = true;
                    cbNameServer.Enabled = true;
                    tbUserServer.Enabled = true;
                    tbPasswordServer.Enabled = true;
                    cbListDataBase.Enabled = true;
                    btnCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    lbsstStatus.Visible = true;
                    lbsstStatus.Text = "Поиск сервера";
                    dbConnection.dtServers += DTServer;
                    threadGetServers = new Thread(dbConnection.GetServers);
                    threadMessage = new Thread(StatusStripMessage);
                    threadMessage.Priority = ThreadPriority.Lowest;
                    threadMessage.IsBackground = true;
                    threadMessage.Start();
                    threadGetServers.Start();
                    break;
            }  
        }
        private void DTServer(DataTable table)   //Загрузка сиписка серверов
        {
            status = 0;

            try
            {
                Action action = () =>
                {
                    foreach (DataRow r in table.Rows)
                    {
                        cbAddressServer.Items.Add(r[0]);
                        cbNameServer.Items.Add(r[1]);
                    }

                    cbAddressServer.Enabled = true;
                    cbNameServer.Enabled = true;
                    tbUserServer.Enabled = true;
                    tbPasswordServer.Enabled = true;
                    btnCheck.Enabled = true;
                };
                Invoke(action);
            }
            catch
            {
                threadGetServers.Abort();
            }
        }
        private void StatusStripMessage()   //сообщение о статусе подключения
        {
            for (int i = 0; i < status;)
            {
                Thread.Sleep(500);

                try
                {
                    Action action = () =>
                    {
                        switch (status)
                        {
                            case (1):
                                if (lbsstStatus.Text != MessageUser.ServerSearchTochki)
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = MessageUser.ServerSearch;
                                break;
                            case (2):
                                if (lbsstStatus.Text != MessageUser.DatabaseSearchTochki)
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = MessageUser.DatabaseSearch;
                                break;
                            case (0):
                                lbsstStatus.Text = "-";
                                lbsstStatus.Visible = false;
                                break;
                        }
                    };
                    Invoke(action);
                }
                catch
                {
                    threadMessage.Abort();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty))
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dbConnection.cds = cbAddressServer.Text + @"\" + cbNameServer.Text;
                dbConnection.cui = tbUserServer.Text;
                dbConnection.cpw= tbPasswordServer.Text;
                status = 2;
                lbsstStatus.Text = MessageUser.DatabaseSearch;
                lbsstStatus.Visible = true;
                dbConnection.dtDatabases += ListDataBases;
                Thread threadMessageCheck = new Thread(StatusStripMessage);
                Thread threadGetDataBases = new Thread(dbConnection.GetDatabases);
                threadMessageCheck.Priority = ThreadPriority.Lowest;
                threadMessageCheck.IsBackground = true;
                threadMessageCheck.Start();
                threadGetDataBases.Start();
            }
        }
        private void ListDataBases(DataTable table) //получение списка баз данных
        {
            Action action = () =>
            {
                cbListDataBase.Items.Clear();
                foreach (DataRow r in table.Rows)
                {
                    cbListDataBase.Items.Add(r[0]);
                }
                status = 0;
                cbListDataBase.Enabled = true;
                btnConnect.Enabled = true;
            };
            Invoke(action);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty) || (cbListDataBase.SelectedIndex == -1))
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Registry_Class registryData = new Registry_Class();
                registryData.SetRegistry(cbAddressServer.Text, cbNameServer.Text, cbListDataBase.Text, tbUserServer.Text, tbPasswordServer.Text);
                //((MainMenuForm)Owner).MainMenu_Load(sender, e);
                DBConnection.logCon = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DBConnection.logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    break;
            }
        }
    }
}
