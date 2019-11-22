﻿using System;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace SCH654
{
    class DBConnection
    {
        public event Action<DataTable> dtServers;
        public event Action<DataTable> dtDatabases;
        public event Action<bool> conState;
        private Registry_Class registry = new Registry_Class();
        public string cds, cui, cpw;
        public static bool logCon;
        public void GetServers()
        {
            SqlDataSourceEnumerator sourceEnumerator
                = SqlDataSourceEnumerator.Instance;
            dtServers(sourceEnumerator.GetDataSources());
        }

        public void GetDatabases()
        {
            SqlConnection sql = new SqlConnection("Data Source = " + cds +
                "; Initial Catalog = master; Persist Security Info = true; " +
                " User ID = " + cui + "; Password = \"" + cpw + "\"");
            try
            {
                SqlCommand command = new SqlCommand("select name from sys.databases " +
                    "where name not in ('master','tempdb','model','msdb')", sql);
                DataTable table = new DataTable();
                sql.Open();
                table.Load(command.ExecuteReader());
                dtDatabases(table);
            }
            catch (SqlException ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString()
                    + ex.Message;
            }
            finally
            {
                sql.Close();
            }
        }

        public void CheckConnection()
        {
            try
            {
                registry.GetRegistry();
                Registry_Class.sqlConnection.Open();
                conState(true);
                logCon = true;
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString()
                    + ex.Message;
                conState(false);
                logCon = false;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }
    }
}