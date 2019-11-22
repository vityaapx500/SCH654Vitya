using System;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace SCH654
{
    class Registry_Class
    {
        public static string DataSource = "", DSServerName = "", InitialCatalog = "", UserID = "", UserPassword = "";
        public static string error_message = "App:start:" + DateTime.Now.ToLongDateString();
        public static SqlConnection sqlConnection = new SqlConnection();
        public void GetRegistry()
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("SCH654");
            try
            {
                DataSource = key.GetValue("DataSource").ToString();
                DSServerName = key.GetValue("DSSeverName").ToString();
                InitialCatalog = key.GetValue("InitialCatalog").ToString();
                UserID = key.GetValue("UserID").ToString();
                UserPassword = key.GetValue("UserPassword").ToString();
            }
            catch
            {
                key.SetValue("DataSourceIP", "Empty");
                key.SetValue("DataSourceServerName", "Empty");
                key.SetValue("InitialCatalog", "Empty");
                key.SetValue("UserID", "Empty");
                key.SetValue("UserPassword", "Empty");
            }
            finally
            {
                sqlConnection.ConnectionString = "Data Source = " + DataSource +
                    "; Initial Catalog = " + InitialCatalog + "; Persist Security Info = true; " +
                    "User ID = " + UserID + "; Password = \"" + UserPassword + "\"";
            }
        }

        public void SetRegistry(string DataSource, string DSServerName, string InitialCatalog, string UserID, string UserPassword)
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("SCH654");
            try
            {
                key.SetValue("DataSourceIP", DataSource);
                key.SetValue("DataSourceServerName", DSServerName);
                key.SetValue("InitialCatalog", InitialCatalog);
                key.SetValue("UserID", UserID);
                key.SetValue("UserPassword", UserPassword);
                GetRegistry();
            }
            catch (Exception ex)
            {
                error_message += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
        }
    }
}