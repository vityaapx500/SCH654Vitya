using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCH654
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            tbDescription.Enabled = true;
            cbOrderStatus.Enabled = false;
            pbAdd.Enabled = false;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            tbDescription.Enabled = false;
            cbOrderStatus.Enabled = true;
            pbUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbDescription.Enabled = true;
            cbOrderStatus.Enabled = false;
            tbDescription.Clear();
            tbDateOrder.Clear();
            cbOrderStatus.SelectedIndex = -1;
            pbAdd.Enabled = true;
            pbUpdate.Enabled = true;
        }
    }
}
