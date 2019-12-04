using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", DBConnection.sqlConnection);
        public DataTable DTDeviceType = new DataTable("device_type");
        public DataTable DTMagazineDevice= new DataTable("magazine_device");
        public DataTable DTMagazineStationery = new DataTable("magazine_stationery");
        public DataTable DTManufacturer = new DataTable("manufacturer");
        public DataTable DTOrders = new DataTable("orders");
        public DataTable DTRoles = new DataTable("roles");
        public DataTable DTUsers = new DataTable("users");

        public string QRMagazineDevice = "SELECT [ID_device], [name_type], [manufacturer], [model], [amount], [date_acceptance] from [dbo].[magazine_device] " +
            "inner join [dbo].[device_type] on [dbo].[magazine_device].[type_ID] = [device_type].[ID_type]";
        public string QRMagazineStationery = "select [ID_stationery], [manufacturer], [name_stationery], [type_stationary], [amount], [date_acceptance] from [dbo].[magazine_stationery] ";
        public string QROrder = "select [ID_order], [description], [date_order], [order_status] from [dbo].[orders] where order_logical_delete = 0";
        public string QRRoles = "select * from [dbo].[roles] where [role_logical_delete] = 0";
        public string QRRolesForComboBox = "select R.[ID_role], [role_name] from [dbo].[roles] R where [role_logical_delete] = 0";
        public string QRUsers = "select [role_name], [surname], [name], [pantronymic], [login_user], [password_user] from [dbo].[users] " +
            "inner join [dbo].[roles] on [dbo].[users].[user_role_id] = [roles].[ID_role] where [user_logical_delete] = 0";
        public SqlDependency dependency = new SqlDependency();
        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(DBConnection.sqlConnection.ConnectionString);
                DBConnection.sqlConnection.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }
        public void DTRolesFill()
        {
            DataTableFill(DTRoles, QRRoles);
        }
        public void DTRolesForComboBoxFill()
        {
            DataTableFill(DTRoles, QRRolesForComboBox);
        }
        public void DTUsersFill()
        {
            DataTableFill(DTUsers, QRUsers);
        }
        public void DTOrderFill()
        {
            DataTableFill(DTOrders, QROrder);
        }
        public void DTMagazineDeviceFill()
        {
            DataTableFill(DTMagazineDevice, QRMagazineDevice);
        }
        public void DTMagazineStationeryFill()
        {
            DataTableFill(DTMagazineStationery, QRMagazineStationery);
        }
    }
}
