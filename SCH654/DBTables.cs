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
        public DataTable DTItems = new DataTable("items");
        public DataTable DTMagazineDevice= new DataTable("magazine_device");
        public DataTable DTMagazineStationery = new DataTable("magazine_stationery");
        public DataTable DTManufacturer = new DataTable("manufacturer");
        public DataTable DTOrders = new DataTable("orders");

        public string QRMagazineDevice = "SELECT [ID_device], [type_ID], [name_type], [manufacturer_ID], [name_manufacturer], [model], [amount], [date_acceptance] from [dbo].[magazine_device] " +
            "inner join [dbo].[device_type] on [dbo].[magazine_device].[type_ID] = device_type.ID_type " +
            "inner join [dbo].[manufacturer] on [dbo].[magazine_device].[manufacturer_ID] = [dbo].[manufacturer].[ID_manufacturer] " +
            "where device_logical_delete = 0";
        public string QRMagazineStationery = "select [ID_stationery], [manufacturer_ID], [name_manufacturer], [name_stationery], [type_stationary], [amount], [date_acceptance] from [dbo].[magazine_stationery] " +
            "inner join [dbo].[manufacturer] on [dbo].[magazine_stationery].[manufacturer_ID] = [dbo].[manufacturer].[ID_manufacturer] where [stationery_logical_delete] = 0";
        public string QROrder = "select [ID_order], [item_ID], [name_item], [description], [date_order], [order_status] from [dbo].[orders] " +
            "inner join [dbo].[items] on [dbo].[orders].[item_ID] = [dbo].[items].[ID_item] where order_logical_delete = 0";
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
