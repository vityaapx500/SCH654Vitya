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
        //Процедуры для таблицы Роли
        public void SPRoleInsert(string roleName, string adminRole, string teacher, string manager_order) //Добавление роли
        {
            ConfigurationProcedure("role_insert");

            storedProcedure.Parameters.AddWithValue("@role_name", roleName);
            storedProcedure.Parameters.AddWithValue("@admin_role", adminRole);
            storedProcedure.Parameters.AddWithValue("@teacher", teacher);
            storedProcedure.Parameters.AddWithValue("@manager_order", manager_order);

            ExecuteStoredProcedure();
        }

        public void SPRoleUpdate(Int32 idRole, string roleName, string adminRole, string teacher, string manager_order) //Обновление данных о роли
        {
            ConfigurationProcedure("role_update");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);
            storedProcedure.Parameters.AddWithValue("@role_name", roleName);
            storedProcedure.Parameters.AddWithValue("@admin_role", adminRole);
            storedProcedure.Parameters.AddWithValue("@teacher", teacher);
            storedProcedure.Parameters.AddWithValue("@manager_order", manager_order);

            ExecuteStoredProcedure();
        }

        public void SPRoleDelete(Int32 idRole) //Удаление роли
        {
            ConfigurationProcedure("role_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        public void SPRoleLogicalDelete(Int32 idRole) //Логическое удаление роли
        {
            ConfigurationProcedure("role_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_role", idRole);

            ExecuteStoredProcedure();
        }

        //Процедуры для таблицы Пользоавтели
        public void SPUsersInsert(string surname, string name, string pantronymic, string loginUser, string passwordUser, Int32 userRoleID) //Добавление пользователя
        {
            ConfigurationProcedure("users_insert");

            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@login_user", loginUser);
            storedProcedure.Parameters.AddWithValue("@password_user", passwordUser);
            storedProcedure.Parameters.AddWithValue("@user_role_id", userRoleID);

            ExecuteStoredProcedure();
        }

        public void SPUsersUpdate(Int32 idUser, string surname, string name, string pantronymic, string loginUser, string passwordUser, Int32 userRoleID) //Обновление данных о пользователе
        {
            ConfigurationProcedure("users_update");

            storedProcedure.Parameters.AddWithValue("ID_user", idUser);
            storedProcedure.Parameters.AddWithValue("@surname", surname);
            storedProcedure.Parameters.AddWithValue("@name", name);
            storedProcedure.Parameters.AddWithValue("@pantronymic", pantronymic);
            storedProcedure.Parameters.AddWithValue("@login_user", loginUser);
            storedProcedure.Parameters.AddWithValue("@password_user", passwordUser);
            storedProcedure.Parameters.AddWithValue("@user_role_id", userRoleID);

            ExecuteStoredProcedure();
        }

        public void SPUsersDelete(Int32 idUser) //Удаление пользователя
        {
            ConfigurationProcedure("users_delete");

            storedProcedure.Parameters.AddWithValue("@ID_user", idUser);

            ExecuteStoredProcedure();
        }

        public void SPUsersLogicalDelete(Int32 idUser) //Логическое удаление пользователя
        {
            ConfigurationProcedure("users_logical_delete");

            storedProcedure.Parameters.AddWithValue("@ID_user", idUser);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Заказы
        public void SPOrderInsert(string description, string dateOrder, string orderStatus) //Добавление заказа
        {
            ConfigurationProcedure("order_insert");

            storedProcedure.Parameters.AddWithValue("@description", description);
            storedProcedure.Parameters.AddWithValue("@date_order", dateOrder);
            storedProcedure.Parameters.AddWithValue("@order_status", orderStatus);

            ExecuteStoredProcedure();
        }

        public void SPOrderUpdate(Int32 idOrder, string description, string dateOrder, string orderStatus) //Обновление данных о заказе
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

        //public void SPOrderLogicalDelete(Int32 idOrder) //Логическое удаление заказа
        //{
        //    ConfigurationProcedure("order_logical_delete");

        //    storedProcedure.Parameters.AddWithValue("@ID_order", idOrder);

        //    ExecuteStoredProcedure();
        //}
    }
}
