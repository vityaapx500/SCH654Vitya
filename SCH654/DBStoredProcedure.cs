using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCH654
{
    class DBStoredProcedure
    {
        private SqlCommand storedProcedure = new SqlCommand("", DBConnection.sqlConnection);

        private void ConfigurationProcedure(string nameProcedure)
        {
            storedProcedure.CommandText = nameProcedure;
            storedProcedure.CommandType = System.Data.CommandType.StoredProcedure;
        }
        public void ExecuteStoredProcedure() //Выполнение процедуры
        {
            try
            {
                DBConnection.sqlConnection.Open();
                DBConnection.sqlConnection.InfoMessage += MessageInformation;
                storedProcedure.ExecuteNonQuery();
                storedProcedure.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }

        public void MessageInformation(object sender, SqlInfoMessageEventArgs e) //Сообщение об ошибке
        {
            MessageBox.Show(e.Message);
        }
        //Процедуры для таблицы Заказы
        public void SPOrderInsert(string description, DateTime dateOrder, string orderStatus) //Добавление заказа
        {
            ConfigurationProcedure("order_insert");

            storedProcedure.Parameters.AddWithValue("@description", description);
            storedProcedure.Parameters.AddWithValue("@date_order", dateOrder);
            storedProcedure.Parameters.AddWithValue("@order_status", orderStatus);

            ExecuteStoredProcedure();
        }

        public void SPOrderUpdate(Int32 idOrder, string description, DateTime dateOrder, string orderStatus) //Обновление данных о заказе
        {
            ConfigurationProcedure("order_update");

            storedProcedure.Parameters.AddWithValue("@ID_order", idOrder);
            storedProcedure.Parameters.AddWithValue("@description", description);
            storedProcedure.Parameters.AddWithValue("@date_order", dateOrder);
            storedProcedure.Parameters.AddWithValue("@order_status", orderStatus);

            ExecuteStoredProcedure();
        }

        public void SPOrderDelete(Int32 idOrder) //Удаление заказа
        {
            ConfigurationProcedure("order_delete");

            storedProcedure.Parameters.AddWithValue("@ID_order", idOrder);

            ExecuteStoredProcedure();
        }

        public void SPOrderLogicalDelete(Int32 idOrder) //Логическое удаление заказа
        {
            ConfigurationProcedure("order_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_order", idOrder);

            ExecuteStoredProcedure();
        }
    }
}
